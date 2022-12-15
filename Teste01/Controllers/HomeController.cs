using Teste01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Teste01.Controllers
    
{
    public class HomeController : Controller
    {

        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Cadastros()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetTodosUsuarios()
        {
            using (UsuarioContexto contextObj = new UsuarioContexto())
            {
                try
                {
                    var listaUsuarios = contextObj.usuario.ToList();
                    return Json(listaUsuarios, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public JsonResult GetUsuarioPorId(string codigo)
        {
            using (UsuarioContexto contextObj = new UsuarioContexto())
            {
                var usuariocodigo = Convert.ToInt32(codigo);
                var getUsuarioPorId = contextObj.usuario.Find(usuariocodigo);
                return Json(getUsuarioPorId, JsonRequestBehavior.AllowGet);
            }
        }

        
    }
  
}