using System.Collections.Generic;
using ERP.PMS.Common.Entities;
using ERP.PMS.Facade.Mapper;
using ERP.PMS.Shared.Models;

namespace ERP.PMS.Facade
{
    public partial class PMSController
    {//[Auth("p:CountOfSalaryDescription"), Log]
        public int CountOfSalaryDescription()
        {
            return Count<SalaryDescription>();
        }
        //[Auth("p:GetAllSalaryDescription"), Log]
        public List<SalaryDescriptionGetDto> GetAllSalaryDescription()
        {
            return GetAll<SalaryDescription>().ToDto<List<SalaryDescription>,List<SalaryDescriptionGetDto>>();
        }
        
        //[Auth("p:AddSalaryDescription"), Log]
        public SalaryDescriptionAddDto AddSalaryDescription(SalaryDescriptionAddDto dto)
        {
            var entity = dto.ToEntity<SalaryDescription,SalaryDescriptionAddDto>();
            var addResult = Add(entity);
            return addResult.ToDto<SalaryDescription,SalaryDescriptionAddDto>();
        }
        
        //[Auth("p:GetSalaryDescriptionById"), Log]
        public SalaryDescriptionGetDto GetSalaryDescriptionById(int id)
        {
            return GetById<SalaryDescription>(id).ToDto<SalaryDescription, SalaryDescriptionGetDto>();
        }
        
        //[Auth("p:UpdateSalaryDescription"), Log]
        public SalaryDescriptionChangeDto UpdateSalaryDescription(SalaryDescriptionChangeDto dto)
        {
            var entity = dto.ToEntity<SalaryDescription, SalaryDescriptionChangeDto>();
            return Change(entity).ToDto<SalaryDescription, SalaryDescriptionChangeDto>();
        }
        
        //[Auth("p:RemoveSalaryDescription"), Log]
        public SalaryDescriptionGetDto RemoveSalaryDescription(int id)
        {
            return Remove<SalaryDescription>(id).ToDto<SalaryDescription, SalaryDescriptionGetDto>();
        }
    }
}