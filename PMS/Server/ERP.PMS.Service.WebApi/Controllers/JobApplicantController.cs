using System.Collections.Generic;
using System.Web.Http;
using Bitspco.Framework.Common;
using ERP.PMS.Shared.Models;

namespace ERP.PMS.Service.WebApi.Controllers
{
    [RoutePrefix("JobApplicant")]
    public class JobApplicantController : ApiController
    {
        [HttpGet]
        public OperationResultCount<List<JobApplicantGetDto>> GetAll() => new OperationResultCount<List<JobApplicantGetDto>>()
        {
            Data = Controller.GetAllJobApplicant(),
            Count = Controller.CountOfJobApplicant()
        };
        [HttpPost]
        public OperationResult<JobApplicantGetDto> GetById(int id) => Controller.GetJobApplicantById(id);

        [HttpPost]
        public OperationResult<JobApplicantAddDto> Add(JobApplicantAddDto addDto) => Controller.AddJobApplicant(addDto);

        [HttpPut]
        public OperationResult<JobApplicantChangeDto> Update(JobApplicantChangeDto updateDto) => Controller.UpdateJobApplicant(updateDto);

        [HttpDelete]
        public OperationResult<JobApplicantGetDto> Delete(int id) => Controller.RemoveJobApplicant(id);
    }
}