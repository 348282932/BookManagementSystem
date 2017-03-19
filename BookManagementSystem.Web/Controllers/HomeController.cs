using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace BookManagementSystem.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}