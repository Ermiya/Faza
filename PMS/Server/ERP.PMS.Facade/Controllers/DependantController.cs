using System.Collections.Generic;
using ERP.PMS.Common.Entities;
using ERP.PMS.Facade.Mapper;
using ERP.PMS.Shared.Models;

namespace ERP.PMS.Facade
{
    public partial class PMSController
    {
        //[Auth("p:CountOfDependant"), Log]
        public int CountOfDependant()
        {
            return Count<Dependant>();
        }
        //[Auth("p:GetAllDependant"), Log]
        public List<DependantGetDto> GetAllDependant()
        {
            return GetAll<Dependant>().ToDto<List<Dependant>,List<DependantGetDto>>();
        }
        
        //[Auth("p:AddDependant"), Log]
        public DependantAddDto AddDependant(DependantAddDto dto)
        {
            var entity = dto.ToEntity<Dependant,DependantAddDto>();
            var addResult = Add(entity);
            return addResult.ToDto<Dependant,DependantAddDto>();
        }
        
        //[Auth("p:GetDependantById"), Log]
        public DependantGetDto GetDependantById(int id)
        {
            return GetById<Dependant>(id).ToDto<Dependant, DependantGetDto>();
        }
        
        //[Auth("p:UpdateDependant"), Log]
        public DependantChangeDto UpdateDependant(DependantChangeDto dto)
        {
            var entity = dto.ToEntity<Dependant, DependantChangeDto>();
            return Change(entity).ToDto<Dependant, DependantChangeDto>();
        }
        
        //[Auth("p:RemoveDependant"), Log]
        public DependantGetDto RemoveDependant(int id)
        {
            return Remove<Dependant>(id).ToDto<Dependant, DependantGetDto>();
        }
    }
}