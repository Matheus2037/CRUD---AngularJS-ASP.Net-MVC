using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teste01.Models.EF;

namespace Teste01.Controllers
{
    public class UserController : Controller
    {
        private AngularjsMvcDbContext db = null;
        public UserController()
        {
            db = new AngularjsMvcDbContext();
        }

        public JsonResult Index()
        {
            var users = db.Users.ToList();
            return Json(users, JsonRequestBehavior.AllowGet);
        }
    }
}