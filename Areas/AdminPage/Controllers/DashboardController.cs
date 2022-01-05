using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doan.Models;

namespace doan.Areas.AdminPage.Controllers
{
    public class DashboardController : Controller
    {
        ShopOnline db = new ShopOnline();
        // GET: AdminPage/Dashboard

        public ActionResult Index()
        {
           
            return View();
           
        }
    }
}