using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.PMS.Shared.Models
{
    //HRWRKXPT
    public class WorkExperienceGetDto : BaseDto
    {
        ///<summary>
        /// شماره پرسنلي
        ///</summary>
        public int PersonnelId { get; set; }

        ///<summary>
        ///تاريخ شروع
        ///</summary>
        public DateTime StartDate { get; set; }

        ///<summary>
        ///تاريخ پايان
        ///</summary>
        public DateTime EndDate { get; set; }

        ///<summary>
        ///عنوان کاري
        ///</summary>
        public string JobTitle { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string JobPlace { get; set; }

        ///<summary>
        ///محل کار
        ///</summary>
        public short Duration { get; set; }

        ///<summary>
        ///مدت قابل قبول به ماه
        ///</summary>
        public short? DurationConfirm { get; set; }

        ///<summary>
        ///توضيحات
        ///</summary>
        public string Description { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public long? DeleterUserId { get; set; }

    }
}