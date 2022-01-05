using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace doan.Areas.AdminPage.Controllers
{
    public class LogoutController : Controller
    {
        // GET: AdminPage/Logout
        public ActionResult LogOUT()
        {
                Session.Clear();
                Session.Abandon();
                return Redirect("~/LoginAD/Index");
        }
    }
}