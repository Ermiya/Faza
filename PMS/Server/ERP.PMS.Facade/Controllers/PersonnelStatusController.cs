using System.Collections.Generic;
using ERP.PMS.Common.Entities;
using ERP.PMS.Facade.Mapper;
using ERP.PMS.Shared.Models;

namespace ERP.PMS.Facade
{
    public partial class PMSController
    {//[Auth("p:CountOfPersonnelStatus"), Log]
        public int CountOfPersonnelStatus()
        {
            return Count<PersonnelStatus>();
        }
        //[Auth("p:GetAllPersonnelStatus"), Log]
        public List<PersonnelStatusGetDto> GetAllPersonnelStatus()
        {
            return GetAll<PersonnelStatus>().ToDto<List<PersonnelStatus>,List<PersonnelStatusGetDto>>();
        }
        
        //[Auth("p:AddPersonnelStatus"), Log]
        public PersonnelStatusAddDto AddPersonnelStatus(PersonnelStatusAddDto dto)
        {
            var entity = dto.ToEntity<PersonnelStatus,PersonnelStatusAddDto>();
            var addResult = Add(entity);
            return addResult.ToDto<PersonnelStatus,PersonnelStatusAddDto>();
        }
        
        //[Auth("p:GetPersonnelStatusById"), Log]
        public PersonnelStatusGetDto GetPersonnelStatusById(int id)
        {
            return GetById<PersonnelStatus>(id).ToDto<PersonnelStatus, PersonnelStatusGetDto>();
        }
        
        //[Auth("p:UpdatePersonnelStatus"), Log]
        public PersonnelStatusChangeDto UpdatePersonnelStatus(PersonnelStatusChangeDto dto)
        {
            var entity = dto.ToEntity<PersonnelStatus, PersonnelStatusChangeDto>();
            return Change(entity).ToDto<PersonnelStatus, PersonnelStatusChangeDto>();
        }
        
        //[Auth("p:RemovePersonnelStatus"), Log]
        public PersonnelStatusGetDto RemovePersonnelStatus(int id)
        {
            return Remove<PersonnelStatus>(id).ToDto<PersonnelStatus, PersonnelStatusGetDto>();
        }
    }
}