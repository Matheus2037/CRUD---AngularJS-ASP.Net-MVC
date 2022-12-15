using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using Teste01.Models;

namespace Teste01.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        public List<UserModel> PutValue()
        {
            var users = new List<UserModel>
            {
                new UserModel{username="SISTEMA", password="candidato123"},
                new UserModel{username="SISTEMA2", password="candidato1234"},
                new UserModel{username="SISTEMA3", password="candidato12345"},
            };
            return users;
        }
        [HttpPost]
        public ActionResult Verify(UserModel usr)
        {
            var u = PutValue();

            var ue = u.Where(tu => tu.username.Equals(usr.username));

            var up = ue.Where(p => p.password.Equals(usr.password));

            if (up.Count() == 1)
            {
                ViewBag.message = "Sucesso no login";
                return View("../Home/Home");
            }
            else
            {
                ViewBag.message = "Falha no login";
                return View("Login");
            }
        }

    }
}