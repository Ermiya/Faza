using Bitspco.Framework.Common;
using Bitspco.Framework.Domain;
using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;
using System.Web.Script.Serialization;

namespace ERP.PMS.Facade.Filters.Exception
{
    public class ExceptionHandlingFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            string exceptionMessage = string.Empty;
            exceptionMessage = actionExecutedContext.Exception.InnerException == null
                ? actionExecutedContext.Exception.Message
                : actionExecutedContext.Exception.InnerException.Message;
            //We can log this exception message to the file or database. 
            
            var result = new OperationResult()
            {
                Success = false,
                Message = "خطایی در سیستم رخ داده",
                Code = (int)HttpStatusCode.InternalServerError
            };
            
            var response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new StringContent(new JavaScriptSerializer().Serialize(result)),
                ReasonPhrase = "Internal Server Error.Please Contact your Administrator."
            };

            actionExecutedContext.Response = response;
            
            //base.OnException(actionExecutedContext);
        }
    }
}