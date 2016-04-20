using System.Web.Mvc;

namespace AlphaProject.Web.Controllers
{
    public class AboutController : AlphaProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}