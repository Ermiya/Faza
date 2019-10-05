using Bitspco.Framework.NetCore.Service.WebApi.OData;
using ERP.PMS.Facade;
using System;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace ERP.PMS.Service.WebApi.Controllers
{
    public class ApiController : System.Web.Http.ApiController
    {
        private PMSController controller;
        private ODataQueryOptions queryOptions;

        public PMSController Controller
        {
            get
            {
                if (controller == null)
                {
                    controller = new PMSController();
                    try
                    {
                        var token = "";
                        var queryString = Request.GetQueryNameValuePairs().ToDictionary(x => x.Key, x => x.Value);
                        if (queryString.ContainsKey("api_key")) token = queryString["api_key"];
                        else if (Request.Headers.Contains("Authorization"))
                        {
                            token = Request.Headers.GetValues("Authorization").FirstOrDefault();
                            if (token.ToLower().IndexOf("bearer") == 0) token = token.Substring(7);
                        }
                        if (!string.IsNullOrEmpty(token)) controller.RegisterAuthenticator(token);
                    }
                    catch (Exception) { }
                    try
                    {
                        controller.RegisterSecurity(HttpContext.Current.Request);
                    }
                    catch (Exception) { }
                }
                return controller;
            }
        }
        protected ODataQueryOptions QueryOptions
        {
            get
            {
                if (queryOptions != null) return queryOptions;
                return queryOptions = new ODataQueryOptions().Parse(HttpContext.Current.Request);
            }
        }
    }
}