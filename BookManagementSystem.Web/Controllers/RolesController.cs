using Abp.Web.Models;
using Abp.Web.Mvc.Controllers;
using Abp.Web.Mvc.Controllers.Results;
using BookManagementSystem.Roles;
using BookManagementSystem.Roles.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BookManagementSystem.Web.Controllers
{
    public class RolesController : AbpController
    {
        private readonly IRoleAppService _roleAppService;

        public RolesController(IRoleAppService roleAppService)
        {
            _roleAppService = roleAppService;
        }

        // GET: Roles
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> UpdateRoleInfo(UpdateRoleInfoInput input)
        {
            await _roleAppService.UpdateRoleInfo(input);

            return Json(new AjaxResponse());
        }

        [HttpPost]
        public async Task<JsonResult> InsertRole(InsertRoleInput input)
        {
            await _roleAppService.InsertRole(input);

            return Json(new AjaxResponse());
        }

        public JsonResult GetAllPermission()
        {
            var data = _roleAppService.GetAllPermission();

            return Json(new AjaxResponse(data), JsonRequestBehavior.AllowGet);
        }
    }
}