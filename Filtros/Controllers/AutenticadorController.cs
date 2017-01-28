using System.Web.Mvc;
using Filtros.Models;

namespace Filtros.Controllers
{
    public class AutenticadorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Logar(Usuario u)
        {
            if (u.Username != null && u.Password != null && u.Username.Equals("K19") && u.Password.Equals("K19"))
            {
                Session["Usuario"] = u;
                return RedirectToAction("Index", "Produto");
            }
            else
            {
                ViewBag.Mensagem = "Usuário ou senha incorretos";
                return View(u);
            }
        }

        public ActionResult Sair()
        {
            Session.Abandon();
            return RedirectToAction("Logar");
        }
    }
}