using System;
using System.ComponentModel.DataAnnotations.Schema;
using ERP.PMS.Shared.Enums;

namespace ERP.PMS.Shared.Models
{
    
    [Table("HRSALRYT")]
    public class SalaryContractChangeDto:BaseDto
    {
        ///<summary>
        ///سريال قرارداد
        ///</summary>
        public int ContractId { get; set; }

        ///<summary>
        ///سريال حکم
        ///</summary>
        public int Serial { get; set; }

        ///<summary>
        ///سريال قسمتهاي سازماني
        ///</summary>
        public int DepartmentId { get; set; }

        ///<summary>
        ///سريال قسمت سازماني محل ماموريت
        ///</summary>
        public int DepartmentAssignment { get; set; }

        ///<summary>
        ///شناسه شغل
        ///</summary>
        public int JobId { get; set; }

        ///<summary>
        ///سريال پست
        ///</summary>
        public int PostId { get; set; }

        ///<summary>
        ///گروه شغلی
        ///</summary>
        public short JobGroup { get; set; }

        ///<summary>
        ///رتبه شغلی
        ///</summary>
        public short JobRank { get; set; }

        public SalaryContractStatus Status { get; set; }


        ///<summary>
        ///تاريخ فعال/غيرفعال شدن حکم
        ///</summary>
        public DateTime? ToggleActivationDate { get; set; }

        ///<summary>
        ///تاريخ ابطال حکم
        ///</summary>
        public DateTime? CancellationDate { get; set; }

        ///<summary>
        ///تاريخ اجرای حکم
        ///</summary>
        public DateTime RunDate { get; set; }

        ///<summary>
        ///سريال شرح حکم
        ///</summary>
        public short SalaryDescriptionId { get; set; }

        ///<summary>
        ///نوع حکم
        ///</summary>
        public short SalaryType { get; set; }

        ///<summary>
        ///نوع بيمه
        ///</summary>
        public InsuranceType InsuranceType { get; set; }

        ///<summary>
        ///سريال فعال/غيرفعال کننده
        ///</summary>
        public int? ApplyUserId { get; set; }

        ///<summary>
        ///سريال ابطال کننده
        ///</summary>
        public int? CancellationUserId { get; set; }

    }

}