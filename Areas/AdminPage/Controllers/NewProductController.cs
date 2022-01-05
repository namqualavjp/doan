using doan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace doan.Areas.AdminPage.Controllers
{
    public class NewProductController : Controller
    {
        ShopOnline db = new ShopOnline();
        // GET: AdminPage/NewProduct
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Index(SanPham sp, HttpPostedFileBase file)
        {
            if (file == null)
            {
                ViewBag.Thongbao = "Chọn hình ảnh vào";
                return View();
            }
            else
            {
                if (ModelState.IsValid)
                {
                    //----lưu tên file 
                    var fileName = Path.GetFileName(file.FileName);
                    //-----lưu đường dẫn
                    var path = Path.Combine(Server.MapPath("~/Storage/Image/product"), fileName);
                    if (System.IO.File.Exists(path))
                        ViewBag.Thongbao = "Hình đã tồn tại";
                    else
                    {
                        file.SaveAs(path);
                    }
                    sp.hinhDD = fileName;
                    db.SanPhams.Add(sp);
                    db.SaveChanges();

                }
                return RedirectToAction("Tongsp","Allproducts");
            }
        }
    }
}