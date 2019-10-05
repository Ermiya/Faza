using System.Collections.Generic;
using System.Web.Http;
using Bitspco.Framework.Common;
using ERP.PMS.Shared.Models;

namespace ERP.PMS.Service.WebApi.Controllers
{
    [RoutePrefix("Dependant")]
    public class DependantController : ApiController
    {
        [HttpGet]
        public OperationResultCount<List<DependantGetDto>> GetAll() => new OperationResultCount<List<DependantGetDto>>()
        {
            Data = Controller.GetAllDependant(),
            Count = Controller.CountOfDependant()
        };
        [HttpPost]
        public OperationResult<DependantGetDto> GetById(int id) => Controller.GetDependantById(id);

        [HttpPost]
        public OperationResult<DependantAddDto> Add(DependantAddDto addDto) => Controller.AddDependant(addDto);

        [HttpPut]
        public OperationResult<DependantChangeDto> Update(DependantChangeDto updateDto) => Controller.UpdateDependant(updateDto);

        [HttpDelete]
        public OperationResult<DependantGetDto> Delete(int id) => Controller.RemoveDependant(id);
    }
}