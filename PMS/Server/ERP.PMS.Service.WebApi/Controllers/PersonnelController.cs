using ERP.PMS.Shared.Models;
using System.Collections.Generic;
using System.Web.Http;
using Bitspco.Framework.Common;

namespace ERP.PMS.Service.WebApi.Controllers
{
    [RoutePrefix("Personnel")]
    public class PersonnelController : ApiController
    {
        [HttpGet]
        public OperationResultCount<List<PersonnelGetDto>> GetAll() => new OperationResultCount<List<PersonnelGetDto>>()
        {
            Data = Controller.GetAllPersonnel(),
            Count = Controller.CountOfPersonnel()
        };
        [HttpPost]
        public OperationResult<PersonnelGetDto> GetById(int id) => Controller.GetPersonnelById(id);

        [HttpPost]
        public OperationResult<PersonnelAddDto> Add(PersonnelAddDto addDto) => Controller.AddPersonnel(addDto);

        [HttpPut]
        public OperationResult<PersonnelChangeDto> Update(PersonnelChangeDto updateDto) => Controller.UpdatePersonnel(updateDto);

        [HttpDelete]
        public OperationResult<PersonnelGetDto> Delete(int id) => Controller.RemovePersonnel(id);
    }
}