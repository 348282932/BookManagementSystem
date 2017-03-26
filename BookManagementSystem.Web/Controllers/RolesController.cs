using Abp.Authorization;
using Abp.Localization;
using Abp.Web.Models;
using Abp.Web.Mvc.Controllers;
using Abp.Web.Mvc.Controllers.Results;
using BookManagementSystem.Roles;
using BookManagementSystem.Roles.Dto;
using BookManagementSystem.Web.Models.Layout;
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

        //public JsonResult List()
        //{
        //    //var data = 

        //    return Json(data);
        //}

        public JsonResult GetRootPermissions()
        {
            var treeData = GetEasyTreeData(_roleAppService.GetRootPermissions());

            return Json(treeData, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 获取 EasyUI 权限树数据源
        /// </summary>
        /// <param name="data"></param>
        /// <param name="treeData"></param>
        /// <returns></returns>
        private List<EasyTreeModel> GetEasyTreeData(IReadOnlyList<Permission> data, List<EasyTreeModel> treeData = null)
        {
            treeData = data.Select(s => new EasyTreeModel
            {
                id = s.Name,
                text = ((LocalizableString)s.DisplayName).Name,
                state = "open",
                children = GetEasyTreeData(s.Children, treeData)
            }).ToList();

            return treeData;
        }
    }
}