using System.Web.Mvc;

namespace Web.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult AccessDenied()
        {
            return View();
        }
    }
}