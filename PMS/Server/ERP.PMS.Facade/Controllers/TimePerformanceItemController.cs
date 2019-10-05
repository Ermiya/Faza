using System.Collections.Generic;
using ERP.PMS.Common.Entities;
using ERP.PMS.Facade.Mapper;
using ERP.PMS.Shared.Models;

namespace ERP.PMS.Facade
{
    public partial class PMSController
    {//[Auth("p:CountOfTimePerformanceItem"), Log]
        public int CountOfTimePerformanceItem()
        {
            return Count<TimePerformanceItem>();
        }
        //[Auth("p:GetAllTimePerformanceItem"), Log]
        public List<TimePerformanceItemGetDto> GetAllTimePerformanceItem()
        {
            return GetAll<TimePerformanceItem>().ToDto<List<TimePerformanceItem>,List<TimePerformanceItemGetDto>>();
        }
        
        //[Auth("p:AddTimePerformanceItem"), Log]
        public TimePerformanceItemAddDto AddTimePerformanceItem(TimePerformanceItemAddDto dto)
        {
            var entity = dto.ToEntity<TimePerformanceItem,TimePerformanceItemAddDto>();
            var addResult = Add(entity);
            return addResult.ToDto<TimePerformanceItem,TimePerformanceItemAddDto>();
        }
        
        //[Auth("p:GetTimePerformanceItemById"), Log]
        public TimePerformanceItemGetDto GetTimePerformanceItemById(int id)
        {
            return GetById<TimePerformanceItem>(id).ToDto<TimePerformanceItem, TimePerformanceItemGetDto>();
        }
        
        //[Auth("p:UpdateTimePerformanceItem"), Log]
        public TimePerformanceItemChangeDto UpdateTimePerformanceItem(TimePerformanceItemChangeDto dto)
        {
            var entity = dto.ToEntity<TimePerformanceItem, TimePerformanceItemChangeDto>();
            return Change(entity).ToDto<TimePerformanceItem, TimePerformanceItemChangeDto>();
        }
        
        //[Auth("p:RemoveTimePerformanceItem"), Log]
        public TimePerformanceItemGetDto RemoveTimePerformanceItem(int id)
        {
            return Remove<TimePerformanceItem>(id).ToDto<TimePerformanceItem, TimePerformanceItemGetDto>();
        }
    }
}