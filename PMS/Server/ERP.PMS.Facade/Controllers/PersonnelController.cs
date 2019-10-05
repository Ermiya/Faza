using System.Collections.Generic;
using ERP.PMS.Common.Entities;
using ERP.PMS.Facade.Mapper;
using ERP.PMS.Shared.Models;

namespace ERP.PMS.Facade
{
    public partial class PMSController
    {//[Auth("p:CountOfPersonnel"), Log]
        public int CountOfPersonnel()
        {
            return Count<Personnel>();
        }
        //[Auth("p:GetAllPersonnel"), Log]
        public List<PersonnelGetDto> GetAllPersonnel()
        {
            return GetAll<Personnel>().ToDto<List<Personnel>,List<PersonnelGetDto>>();
        }
        
        //[Auth("p:AddPersonnel"), Log]
        public PersonnelAddDto AddPersonnel(PersonnelAddDto dto)
        {
            var entity = dto.ToEntity<Personnel,PersonnelAddDto>();
            var addResult = Add(entity);
            return addResult.ToDto<Personnel,PersonnelAddDto>();
        }
        
        //[Auth("p:GetPersonnelById"), Log]
        public PersonnelGetDto GetPersonnelById(int id)
        {
            return GetById<Personnel>(id).ToDto<Personnel, PersonnelGetDto>();
        }
        
        //[Auth("p:UpdatePersonnel"), Log]
        public PersonnelChangeDto UpdatePersonnel(PersonnelChangeDto dto)
        {
            var entity = dto.ToEntity<Personnel, PersonnelChangeDto>();
            return Change(entity).ToDto<Personnel, PersonnelChangeDto>();
        }
        
        //[Auth("p:RemovePersonnel"), Log]
        public PersonnelGetDto RemovePersonnel(int id)
        {
            return Remove<Personnel>(id).ToDto<Personnel, PersonnelGetDto>();
        }
    }
}