using System.Collections.Generic;
using ERP.PMS.Common.Entities;
using ERP.PMS.Facade.Mapper;
using ERP.PMS.Shared.Models;

namespace ERP.PMS.Facade
{
    public partial class PMSController
    {//[Auth("p:CountOfJobApplicant"), Log]
        public int CountOfJobApplicant()
        {
            return Count<JobApplicant>();
        }
        //[Auth("p:GetAllJobApplicant"), Log]
        public List<JobApplicantGetDto> GetAllJobApplicant()
        {
            return GetAll<JobApplicant>().ToDto<List<JobApplicant>,List<JobApplicantGetDto>>();
        }
        
        //[Auth("p:AddJobApplicant"), Log]
        public JobApplicantAddDto AddJobApplicant(JobApplicantAddDto dto)
        {
            var entity = dto.ToEntity<JobApplicant,JobApplicantAddDto>();
            var addResult = Add(entity);
            return addResult.ToDto<JobApplicant,JobApplicantAddDto>();
        }
        
        //[Auth("p:GetJobApplicantById"), Log]
        public JobApplicantGetDto GetJobApplicantById(int id)
        {
            return GetById<JobApplicant>(id).ToDto<JobApplicant, JobApplicantGetDto>();
        }
        
        //[Auth("p:UpdateJobApplicant"), Log]
        public JobApplicantChangeDto UpdateJobApplicant(JobApplicantChangeDto dto)
        {
            var entity = dto.ToEntity<JobApplicant, JobApplicantChangeDto>();
            return Change(entity).ToDto<JobApplicant, JobApplicantChangeDto>();
        }
        
        //[Auth("p:RemoveJobApplicant"), Log]
        public JobApplicantGetDto RemoveJobApplicant(int id)
        {
            return Remove<JobApplicant>(id).ToDto<JobApplicant, JobApplicantGetDto>();
        }
    }
}