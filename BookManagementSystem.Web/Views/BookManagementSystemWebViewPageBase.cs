using Abp.Web.Mvc.Views;

namespace BookManagementSystem.Web.Views
{
    public abstract class BookManagementSystemWebViewPageBase : BookManagementSystemWebViewPageBase<dynamic>
    {

    }

    public abstract class BookManagementSystemWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected BookManagementSystemWebViewPageBase()
        {
            LocalizationSourceName = BookManagementSystemConsts.LocalizationSourceName;
        }
    }
}