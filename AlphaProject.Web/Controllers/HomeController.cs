using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace AlphaProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AlphaProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}