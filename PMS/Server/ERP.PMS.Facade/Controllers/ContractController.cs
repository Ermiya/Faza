using System;
using System.Collections.Generic;
using ERP.PMS.Common.Entities;
using ERP.PMS.Facade.Mapper;
using ERP.PMS.Shared.Models;

namespace ERP.PMS.Facade
{
    public partial class PMSController
    {
        //[Auth("p:CountOfContract"), Log]
        public int CountOfContract()
        {
            return Count<Contract>();
        }
        //[Auth("p:GetAllContract"), Log]
        public List<ContractGetDto> GetAllContract()
        {
            return GetAll<Contract>().ToDto<List<Contract>,List<ContractGetDto>>();
        }
        
        //[Auth("p:AddContract"), Log]
        public ContractAddDto AddContract(ContractAddDto dto)
        {
            var entity = dto.ToEntity<Contract,ContractAddDto>();
            var addResult = Add(entity);
            return addResult.ToDto<Contract,ContractAddDto>();
        }
        
        //[Auth("p:GetContractById"), Log]
        public ContractGetDto GetContractById(int id)
        {
            return GetById<Contract>(id).ToDto<Contract, ContractGetDto>();
        }
        
        //[Auth("p:UpdateContract"), Log]
        public ContractChangeDto UpdateContract(ContractChangeDto dto)
        {
            var entity = dto.ToEntity<Contract, ContractChangeDto>();
            return Change(entity).ToDto<Contract, ContractChangeDto>();
        }
        
        //[Auth("p:RemoveContract"), Log]
        public ContractGetDto RemoveContract(int id)
        {
            return Remove<Contract>(id).ToDto<Contract, ContractGetDto>();
        }
    }
}