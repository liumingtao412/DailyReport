using Abp.Web.Mvc.Views;

namespace AlphaProject.Web.Views
{
    public abstract class AlphaProjectWebViewPageBase : AlphaProjectWebViewPageBase<dynamic>
    {

    }

    public abstract class AlphaProjectWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AlphaProjectWebViewPageBase()
        {
            LocalizationSourceName = AlphaProjectConsts.LocalizationSourceName;
        }
    }
}