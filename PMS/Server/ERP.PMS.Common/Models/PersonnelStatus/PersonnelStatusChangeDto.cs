using System;
using System.ComponentModel.DataAnnotations.Schema;
using ERP.PMS.Shared.Enums;

namespace ERP.PMS.Shared.Models
{
    
    [Table("HREDUSTT")]
    public class PersonnelStatusChangeDto:BaseDto
    {
        ///<summary>
        ///شماره پرسنلي
        ///</summary>
        public int PersonnelId { get; set; }

        ///<summary>
        ///تاريخ شروع
        ///</summary>
        public DateTime? StartDate { get; set; }

        ///<summary>
        ///تاريخ پايان
        ///</summary>
        public DateTime? EndDate { get; set; }

        ///<summary>
        ///نوع مدرک
        ///</summary>
        public EducationType EducationType { get; set; }

        ///<summary>
        ///نام دانشگاه
        ///</summary>
        public string UniversityName { get; set; }

        ///<summary>
        ///نام رشته تحصيلي
        ///</summary>
        public string FieldName { get; set; }

        ///<summary>
        ///گرایش تحصیلی
        ///</summary>
        public string Orientation { get; set; }

        ///<summary>
        ///معدل
        ///</summary>
        public decimal? Average { get; set; }

        ///<summary>
        ///وضعيت
        ///</summary>
        public GeneralStatus  Status { get; set; }
    }
}