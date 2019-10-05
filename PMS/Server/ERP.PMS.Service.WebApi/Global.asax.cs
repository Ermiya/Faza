using System.Web.Http;
using ERP.PMS.Facade.Mapper;

namespace ERP.PMS.Service.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapperConfig.Configure();
        }
    }
}
