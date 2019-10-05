using System.Collections.Generic;
using System.Web.Http;
using Bitspco.Framework.Common;
using ERP.PMS.Shared.Models;

namespace ERP.PMS.Service.WebApi.Controllers
{
    [RoutePrefix("Contract")]
    public class ContractController : ApiController
    {
        [HttpGet]
        public OperationResultCount<List<ContractGetDto>> GetAll() => new OperationResultCount<List<ContractGetDto>>()
            {
                Data = Controller.GetAllContract(),
                Count = Controller.CountOfContract()
            };
        [HttpGet]
        public OperationResult<ContractGetDto> GetById(int id) => Controller.GetContractById(id);

        [HttpPost]
        public OperationResult<ContractAddDto> Add(ContractAddDto addDto) => Controller.AddContract(addDto);

        [HttpPut]
        public OperationResult<ContractChangeDto> Update(ContractChangeDto updateDto) => Controller.UpdateContract(updateDto);

        [HttpDelete]
        public OperationResult<ContractGetDto> Delete(int id) => Controller.RemoveContract(id);

    }
}