using Abp.Web.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookManagementSystem.Web.Controllers
{
    public class AuthorsController : AbpController
    {
        // GET: Author
        public ActionResult Index()
        {
            return View();
        }
    }
}