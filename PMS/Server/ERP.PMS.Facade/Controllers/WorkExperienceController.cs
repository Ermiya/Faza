using System.Collections.Generic;
using ERP.PMS.Common.Entities;
using ERP.PMS.Facade.Mapper;
using ERP.PMS.Shared.Models;

namespace ERP.PMS.Facade
{
    public partial class PMSController
    {//[Auth("p:CountOfWorkExperience"), Log]
        public int CountOfWorkExperience()
        {
            return Count<WorkExperience>();
        }
        //[Auth("p:GetAllWorkExperience"), Log]
        public List<WorkExperienceGetDto> GetAllWorkExperience()
        {
            return GetAll<WorkExperience>().ToDto<List<WorkExperience>,List<WorkExperienceGetDto>>();
        }
        
        //[Auth("p:AddWorkExperience"), Log]
        public WorkExperienceAddDto AddWorkExperience(WorkExperienceAddDto dto)
        {
            var entity = dto.ToEntity<WorkExperience,WorkExperienceAddDto>();
            var addResult = Add(entity);
            return addResult.ToDto<WorkExperience,WorkExperienceAddDto>();
        }
        
        //[Auth("p:GetWorkExperienceById"), Log]
        public WorkExperienceGetDto GetWorkExperienceById(int id)
        {
            return GetById<WorkExperience>(id).ToDto<WorkExperience, WorkExperienceGetDto>();
        }
        
        //[Auth("p:UpdateWorkExperience"), Log]
        public WorkExperienceChangeDto UpdateWorkExperience(WorkExperienceChangeDto dto)
        {
            var entity = dto.ToEntity<WorkExperience, WorkExperienceChangeDto>();
            return Change(entity).ToDto<WorkExperience, WorkExperienceChangeDto>();
        }
        
        //[Auth("p:RemoveWorkExperience"), Log]
        public WorkExperienceGetDto RemoveWorkExperience(int id)
        {
            return Remove<WorkExperience>(id).ToDto<WorkExperience, WorkExperienceGetDto>();
        }
    }
}