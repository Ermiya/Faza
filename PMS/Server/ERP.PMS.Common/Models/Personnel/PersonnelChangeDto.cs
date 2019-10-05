using System;
using System.ComponentModel.DataAnnotations.Schema;
using ERP.PMS.Shared.Enums;

namespace ERP.PMS.Shared.Models
{
    //HRPRSNLT
    public partial class PersonnelChangeDto:BaseDto
    {
        ///<summary>
        ///نام
        ///</summary>
        public string FirstName { get; set; }

        ///<summary>
        ///نام خانوادگي
        ///</summary>
        public string LastName { get; set; }

        ///<summary>
        ///وضعيت پرسنل
        ///</summary>
        public short Status { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int? JobId { get; set; }

        ///<summary>
        ///نام لاتين
        ///</summary>
        public string FirstNameEnglish { get; set; }

        ///<summary>
        ///نام خانوادگي لاتين
        ///</summary>
        public string LastNameEnglish { get; set; }

        ///<summary>
        ///شماره شناسنامه
        ///</summary>
        public string IdNumber { get; set; }

        ///<summary>
        ///تاريخ تولد
        ///</summary>
        public DateTime BirthDate { get; set; }

        ///<summary>
        ///جنسیت
        ///</summary>
        public Gender Gender { get; set; }

        ///<summary>
        ///سريال شهر محل صدور
        ///</summary>
        public int? IssuanceCityId { get; set; }

        ///<summary>
        ///سريال شهر محل تولد
        ///</summary>
        public int BirthPlaceCityId{ get; set; }

        ///<summary>
        ///تاريخ ازدواج
        ///</summary>
        public DateTime? MarriageDate { get; set; }

        ///<summary>
        ///آدرس
        ///</summary>
        public string Address { get; set; }

        ///<summary>
        ///شماره تلفن
        ///</summary>
        public string PhoneNumber { get; set; }

        ///<summary>
        ///شماره موبايل
        ///</summary>
        public string MobileNumber { get; set; }

        ///<summary>
        ///درصد جانبازي
        ///</summary>
        public decimal? InjuriesPercentage { get; set; }

        ///<summary>
        ///نوع مسکن
        ///</summary>
        public HousingType? HousingType { get; set; }

        ///<summary>
        ///نوع بيمه
        ///</summary>
        public InsuranceType? InsuranceType { get; set; }

        ///<summary>
        ///گروه خوني
        ///</summary>
        public BloodType? BloodType { get; set; }

        ///<summary>
        ///وضعيت تاهل
        ///</summary>
        public MaritalStatus MaritalStatus { get; set; }

        ///<summary>
        ///
        ///</summary>
        public ReligionType? ReligionType { get; set; }

        ///<summary>
        ///نظام وظيفه
        ///</summary>
        public SoldierType? SoldierType { get; set; }

        ///<summary>
        ///خانواده شهيد
        ///</summary>
        public bool? IsMartyrFamily{ get; set; }

        ///<summary>
        ///فرزند شهيد
        ///</summary>
        public bool? IsMartyrChild { get; set; }

        ///<summary>
        ///مدت جبهه
        ///</summary>
        public short? FrontDuration { get; set; }

        ///<summary>
        ///مدت اسارت
        ///</summary>
        public short? BondageDuration { get; set; }

        ///<summary>
        /// توالي حضور در جبهه
        ///</summary>
        public FrontFrequency? FrontFrequency { get; set; }

        ///<summary>
        ///كدپستي
        ///</summary>
        public string PostalCode { get; set; }

        ///<summary>
        ///کد ملی
        ///</summary>
        public string NationalCode { get; set; }

        ///<summary>
        ///سريال شناسنامه
        ///</summary>
        public string IdSerialNumber { get; set; }

        ///<summary>
        ///عکس پرسنل
        ///</summary>
        public byte[] Picture { get; set; }


    }
}