using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doan.Models;
using PagedList;
using PagedList.Mvc;
using System.IO;
using System.Data.Entity;

namespace doan.Areas.AdminPage.Controllers
{
    public class AllproductsController : Controller
    {
        ShopOnline db = new ShopOnline();
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminPage/News
        public ActionResult Tongsp(int? page)
        {
            var list = new List<SanPham>();
            list = db.SanPhams.ToList();
            int pageSize = 15;
            int pageNum = (page ?? 1);
            list = list.OrderByDescending(n => n.giaBan).ToList();
            return View(list.ToPagedList(pageNum, pageSize));
        }

        [HttpGet]
        public ActionResult Xoasanpham(string MASP)
        {
            SanPham sp = db.SanPhams.SingleOrDefault(n => n.maSP == MASP);
            ViewBag.MASP = sp.maSP;
            if(sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sp);
        }
        [HttpPost,ActionName("Xoasanpham")]
        public ActionResult Xacnhanxoa(string MASP)
        {
            SanPham sp = db.SanPhams.SingleOrDefault(n => n.maSP == MASP);
            ViewBag.MASP = sp.maSP;
            if(sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            db.SanPhams.Remove(sp);
            db.SaveChanges();
            return RedirectToAction("Tongsp");
        }
        [HttpGet]
        public ActionResult Suasp(string MASP)
        {
            var sp = db.SanPhams.Where(n => n.maSP == MASP).FirstOrDefault();
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sp);
        }

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Suasp(SanPham spham, HttpPostedFileBase files)
        {
            if (files != null)
            {
                var fileName = Path.GetFileName(files.FileName);
                //-----lưu đường dẫn
                var path = Path.Combine(Server.MapPath("~/Storage/Image/product"), fileName);
                if (System.IO.File.Exists(path))
                    ViewBag.Thongbao = "Hình đã tồn tại";
                else
                {
                    files.SaveAs(path);
                }
                spham.hinhDD = fileName;
                db.Entry(spham).State = EntityState.Modified;
                //UpdateModel(spham);
                db.SaveChanges();
            }
            else
            {
                    ViewBag.Thongbao = "Chèn ảnh khác";
                    return View();
            }
                return RedirectToAction("Tongsp", "Allproducts");
        }
    }
}