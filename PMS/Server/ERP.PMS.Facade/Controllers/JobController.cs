using System.Collections.Generic;
using ERP.PMS.Common.Entities;
using ERP.PMS.Facade.Mapper;
using ERP.PMS.Shared.Models;

namespace ERP.PMS.Facade
{
    public partial class PMSController
    {//[Auth("p:CountOfJob"), Log]
        public int CountOfJob()
        {
            return Count<Job>();
        }
        //[Auth("p:GetAllJob"), Log]
        public List<JobGetDto> GetAllJob()
        {
            return GetAll<Job>().ToDto<List<Job>,List<JobGetDto>>();
        }
        
        //[Auth("p:AddJob"), Log]
        public JobAddDto AddJob(JobAddDto dto)
        {
            var entity = dto.ToEntity<Job,JobAddDto>();
            var addResult = Add(entity);
            return addResult.ToDto<Job,JobAddDto>();
        }
        
        //[Auth("p:GetJobById"), Log]
        public JobGetDto GetJobById(int id)
        {
            return GetById<Job>(id).ToDto<Job, JobGetDto>();
        }
        
        //[Auth("p:UpdateJob"), Log]
        public JobChangeDto UpdateJob(JobChangeDto dto)
        {
            var entity = dto.ToEntity<Job, JobChangeDto>();
            return Change(entity).ToDto<Job, JobChangeDto>();
        }
        
        //[Auth("p:RemoveJob"), Log]
        public JobGetDto RemoveJob(int id)
        {
            return Remove<Job>(id).ToDto<Job, JobGetDto>();
        }
    }
}