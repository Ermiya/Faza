using System.Collections.Generic;
using ERP.PMS.Common.Entities;
using ERP.PMS.Facade.Mapper;
using ERP.PMS.Shared.Models;

namespace ERP.PMS.Facade
{
    public partial class PMSController
    {//[Auth("p:CountOfSalaryContract"), Log]
        public int CountOfSalaryContract()
        {
            return Count<SalaryContract>();
        }
        //[Auth("p:GetAllSalaryContract"), Log]
        public List<SalaryContractGetDto> GetAllSalaryContract()
        {
            return GetAll<SalaryContract>().ToDto<List<SalaryContract>,List<SalaryContractGetDto>>();
        }
        
        //[Auth("p:AddSalaryContract"), Log]
        public SalaryContractGetDto AddSalaryContract(SalaryContractAddDto dto)
        {
            var entity = dto.ToEntity<SalaryContract,SalaryContractAddDto>();
            var addResult = Add(entity);
            return addResult.ToDto<SalaryContract,SalaryContractGetDto>();
        }
        
        //[Auth("p:GetSalaryContractById"), Log]
        public SalaryContractGetDto GetSalaryContractById(int id)
        {
            return GetById<SalaryContract>(id).ToDto<SalaryContract, SalaryContractGetDto>();
        }
        
        //[Auth("p:UpdateSalaryContract"), Log]
        public SalaryContractGetDto UpdateSalaryContract(SalaryContractChangeDto dto)
        {
            var entity = dto.ToEntity<SalaryContract, SalaryContractChangeDto>();
            return Change(entity).ToDto<SalaryContract, SalaryContractGetDto>();
        }
        
        //[Auth("p:RemoveSalaryContract"), Log]
        public SalaryContractGetDto RemoveSalaryContract(int id)
        {
            return Remove<SalaryContract>(id).ToDto<SalaryContract, SalaryContractGetDto>();
        }
    }
}