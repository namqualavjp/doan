using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace doan.Areas.AdminPage.Controllers
{
    public class CustomersController : Controller
    {
        // GET: AdminPage/Customers
        public ActionResult Index()
        {
            return View();
        }
    }
}