using ERP.PMS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using Bitspco.Framework.Common;

namespace ERP.PMS.Service.WebApi.Controllers
{
    [RoutePrefix("TimePerformance")]
    public class TimePerformanceController : ApiController
    {
        private string _lock = "";

        [HttpGet]
        public OperationResultCount<List<TimePerformanceGetDto>> GetAll() => new OperationResultCount<List<TimePerformanceGetDto>>()
        {
            Data = Controller.GetAllTimePerformance(),
            Count = Controller.CountOfTimePerformance()
        };
        [HttpPost]
        public OperationResult<TimePerformanceGetDto> GetById(int id) => Controller.GetTimePerformanceById(id);

        [HttpPost]
        public OperationResult<TimePerformanceAddDto> Add(TimePerformanceAddDto addDto) =>
            Controller.AddTimePerformance(addDto);

        [HttpPut]
        public OperationResult<TimePerformanceChangeDto> Update(TimePerformanceChangeDto updateDto) =>
            Controller.UpdateTimePerformance(updateDto);

        [HttpDelete]
        public OperationResult<TimePerformanceGetDto> Delete(int id) => Controller.RemoveTimePerformance(id);


        [HttpPost, Route(nameof(Upload))]
        public OperationResult<string> Upload()
        {
            HttpRequest request = HttpContext.Current.Request;
            string directory = $"{AppDomain.CurrentDomain.BaseDirectory}/Files/TimePerformance";
            if (request.Files.Count <= 0) return "Undone!";
            HttpPostedFile file = request.Files[0];
            file.SaveAs($"{directory}/{file.FileName}{DateTime.Now.ToString()}");
            Controller.AddTimePerformanceByExcel($"{directory}/{file.FileName}");
            return "Done!";
        }
    }
}