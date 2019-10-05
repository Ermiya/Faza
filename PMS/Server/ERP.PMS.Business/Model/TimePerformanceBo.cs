using ERP.PMS.Business.Attribute;
using Microsoft.Office.Interop.Excel;

namespace ERP.PMS.Business.Model
{
    public class TimePerformanceBo
    {
        [ExcelColumn("شناسه")] public int Id { get; set; }
        [ExcelColumn("نام","اسم")] public string FirstName { get; set; }
        [ExcelColumn("نام خوانوادگی","فامیلی")] public string LastName { get; set; }
    }
}