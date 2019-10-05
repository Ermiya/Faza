using System.Collections.Generic;
using ERP.PMS.Common.Entities;
using ERP.PMS.Facade.Mapper;
using ERP.PMS.Shared.Models;

namespace ERP.PMS.Facade
{
    public partial class PMSController
    {//[Auth("p:CountOfTimePerformance"), Log]
        public int CountOfTimePerformance()
        {
            return Count<TimePerformance>();
        }
        //[Auth("p:GetAllTimePerformance"), Log]
        public List<TimePerformanceGetDto> GetAllTimePerformance()
        {
            return GetAll<TimePerformance>().ToDto<List<TimePerformance>, List<TimePerformanceGetDto>>();
        }

        //[Auth("p:AddTimePerformance"), Log]
        public TimePerformanceAddDto AddTimePerformance(TimePerformanceAddDto dto)
        {
            var entity = dto.ToEntity<TimePerformance, TimePerformanceAddDto>();
            var addResult = Add(entity);
            return addResult.ToDto<TimePerformance, TimePerformanceAddDto>();
        }

        //[Auth("p:GetTimePerformanceById"), Log]
        public TimePerformanceGetDto GetTimePerformanceById(int id)
        {
            return GetById<TimePerformance>(id).ToDto<TimePerformance, TimePerformanceGetDto>();
        }

        //[Auth("p:UpdateTimePerformance"), Log]
        public TimePerformanceChangeDto UpdateTimePerformance(TimePerformanceChangeDto dto)
        {
            var entity = dto.ToEntity<TimePerformance, TimePerformanceChangeDto>();
            return Change(entity).ToDto<TimePerformance, TimePerformanceChangeDto>();
        }

        //[Auth("p:RemoveTimePerformance"), Log]
        public TimePerformanceGetDto RemoveTimePerformance(int id)
        {
            return Remove<TimePerformance>(id).ToDto<TimePerformance, TimePerformanceGetDto>();
        }

        //[Auth("p:AddTimePerformanceByExcel"), Log]
        public void AddTimePerformanceByExcel(string path)
        {
            Business.AddTimePerformanceByExcel(path);
        }
    }
}