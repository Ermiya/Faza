using ERP.Accounting.Common.Entities;
using Sigma.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ERP.Accounting.Service.WebApi.Controllers
{
    [RoutePrefix("Menu")]
    public class MenuController : ApiController
    {
        [Route(""), HttpGet]
        public IQueryable<Menu> GetAll() => Controller.Set<Menu>();
        [Route("{id:int}"), HttpGet]
        public Menu Get(int id) => Controller.GetById<Menu>(id);
        [Route(""), HttpPost]
        public OperationResult<Menu> Add(Menu obj) => Controller.Add(obj);
        [Route(""), HttpPatch]
        public OperationResult<Menu> Change(Menu obj) => Controller.Change(obj);
        [Route("{id:int}"), HttpPatch]
        public OperationResult<Menu> Change([FromUri]int id, [FromBody]Menu obj) { obj.Id = id; return Controller.Change(obj); }
        [Route("{id:int}"), HttpDelete]
        public OperationResult<Menu> Remove(int id) => Controller.Remove<Menu>(id);
    }
}
