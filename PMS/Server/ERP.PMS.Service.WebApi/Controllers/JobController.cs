using Bitspco.Framework.Common;
using ERP.PMS.Shared.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace ERP.PMS.Service.WebApi.Controllers
{
    [RoutePrefix("Job")]
    public class JobController : ApiController
    {
        [HttpGet]
        public OperationResultCount<List<JobGetDto>> GetAll() => new OperationResultCount<List<JobGetDto>>()
        {
            Data = Controller.GetAllJob(),
            Count = Controller.CountOfJob()
        };
        [HttpPost]
        public OperationResult<JobGetDto> GetById(int id) => Controller.GetJobById(id);

        [HttpPost]
        public OperationResult<JobAddDto> Add(JobAddDto addDto) => Controller.AddJob(addDto);

        [HttpPut]
        public OperationResult<JobChangeDto> Update(JobChangeDto updateDto) => Controller.UpdateJob(updateDto);

        [HttpDelete]
        public OperationResult<JobGetDto> Delete(int id) => Controller.RemoveJob(id);
    }
}