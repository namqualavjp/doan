using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doan.Models;

namespace doan.Areas.AdminPage.Controllers
{
    public class OrdersController : Controller
    {
        // GET: AdminPage/Orders
        public ActionResult Index()
        {
            return View();
        }
    }
}