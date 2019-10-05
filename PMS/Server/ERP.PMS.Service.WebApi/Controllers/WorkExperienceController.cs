using ERP.PMS.Shared.Models;
using System.Collections.Generic;
using System.Web.Http;
using Bitspco.Framework.Common;

namespace ERP.PMS.Service.WebApi.Controllers
{
    [RoutePrefix("WorkExperience")]
    public class WorkExperienceController : ApiController
    {
        [HttpGet]
        public OperationResultCount<List<WorkExperienceGetDto>> GetAll() => new OperationResultCount<List<WorkExperienceGetDto>>()
        {
            Data = Controller.GetAllWorkExperience(),
            Count = Controller.CountOfWorkExperience()
        };
        [HttpGet]
        public OperationResult<WorkExperienceGetDto> GetById(int id) => Controller.GetWorkExperienceById(id);

        [HttpPost]
        public OperationResult<WorkExperienceAddDto> Add(WorkExperienceAddDto addDto) => Controller.AddWorkExperience(addDto);

        [HttpPut]
        public OperationResult<WorkExperienceChangeDto> Update(WorkExperienceChangeDto updateDto) => Controller.UpdateWorkExperience(updateDto);

        [HttpDelete]
        public OperationResult<WorkExperienceGetDto> Delete(int id) => Controller.RemoveWorkExperience(id);
        
//        
//        [Route(""), HttpGet]
//        public OperationResultCount<List<WorkExperienceGetDto>> Select(ODataQueryOptions<WorkExperienceGetDto> options) 
//            => GetODataQueryOptionsResult<Calendar, CalendarGetDto>(Controller.Set<WorkExperienceGetDto>(), options);
    }
}