using ERP.PMS.Shared.Models;
using System.Collections.Generic;
using System.Web.Http;
using Bitspco.Framework.Common;

namespace ERP.PMS.Service.WebApi.Controllers
{
    [RoutePrefix("SalaryDescription")]
    public class SalaryDescriptionController : ApiController
    {
        [HttpGet]
        public OperationResultCount<List<SalaryDescriptionGetDto>> GetAll() => new OperationResultCount<List<SalaryDescriptionGetDto>>()
        {
            Data = Controller.GetAllSalaryDescription(),
            Count = Controller.CountOfSalaryDescription()
        };
        [HttpPost]
        public OperationResult<SalaryDescriptionGetDto> GetById(int id) => Controller.GetSalaryDescriptionById(id);

        [HttpPost]
        public OperationResult<SalaryDescriptionAddDto> Add(SalaryDescriptionAddDto addDto) => Controller.AddSalaryDescription(addDto);

        [HttpPut]
        public OperationResult<SalaryDescriptionChangeDto> Update(SalaryDescriptionChangeDto updateDto) => Controller.UpdateSalaryDescription(updateDto);

        [HttpDelete]
        public OperationResult<SalaryDescriptionGetDto> Delete(int id) => Controller.RemoveSalaryDescription(id);
    }
}