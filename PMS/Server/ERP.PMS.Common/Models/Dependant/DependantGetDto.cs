using System;
using System.ComponentModel.DataAnnotations.Schema;
using ERP.PMS.Shared.Enums;

namespace ERP.PMS.Shared.Models
{
    /// <summary>
    ///افراد تحت تکفل 
    /// </summary>
    //HRDPNDNT
    public class DependantGetDto:BaseDto
    {
        ///<summary>
        ///شماره پرسنلي
        ///</summary>
        public int PersonnelId { get; set; }

        ///<summary>
        ///نام
        ///</summary>
        public string FirstName { get; set; }

        ///<summary>
        ///نام خانوادگي
        ///</summary>
        public string LastName { get; set; }

        ///<summary>
        ///تاريخ اعتبار
        ///</summary>
        public DateTime? ValidityDate { get; set; }

        ///<summary>
        ///جنسیت
        ///</summary>
        public Gender Gender { get; set; }

        ///<summary>
        ///نسبت
        ///</summary>
        public DependantRelation Relation { get; set; }

        ///<summary>
        ///تاریخ تولد
        ///</summary>
        public DateTime? BirthDate { get; set; }

        ///<summary>
        ///تاریخ ازدواج
        ///</summary>
        public DateTime? MarriageDate { get; set; }

        ///<summary>
        ///شماره شناسنامه
        ///</summary>
        public string IdNumber { get; set; }

        ///<summary>
        ///نوع مدرک
        ///</summary>
        public EducationType EducationType { get; set; }

        ///<summary>
        ///سريال شهر محل تولد
        ///</summary>

        public int BirthPlaceCityId { get; set; }
        ///<summary>
        ///تحت تکلف
        ///</summary>
        public bool IsDependant { get; set; }

        ///<summary>
        ///بيه تكميلي
        ///</summary>
        public bool IsSupplementaryInsured { get; set; }

        /// <summary>
        /// کد ملی
        /// </summary>
        public string NationalCode { get; set; }


        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public long? DeleterUserId { get; set; }

    }
}