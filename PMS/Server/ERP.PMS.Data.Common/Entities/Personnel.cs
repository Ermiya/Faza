using Bitspco.Framework.Domain.Entities;
using Bitspco.Framework.Domain.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using ERP.PMS.Shared.Enums;

namespace ERP.PMS.Common.Entities
{
    [Table("HRPRSNLT")]
    public class Personnel:Entity, IAudited
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

        public virtual Job Job { get; set; }
        
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
        /// 
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
        public bool IsMartyrChild { get; set; }

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


        #region Auditing

        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public long? DeleterUserId { get; set; }

        #endregion

        #region Relations

        public virtual IList<Contract> Contracts { get; set; } 
        public virtual IList<PersonnelStatus> PersonnelStatuses { get; set; } 
        public virtual IList<TimePerformance> TimePerformances { get; set; } 
        public virtual IList<Dependant> Dependants { get; set; }

        #endregion
        

    }
    
            
    public class PersonnelConfig : EntityTypeConfiguration<Personnel>
    {
        public PersonnelConfig ()
        {
            ToTable("HRPRSNLT").HasKey(p => p.Id);
            Property(t => t.FirstName).HasColumnName("name");
            Property(t => t.LastName).HasColumnName("family");
            Property(t => t.Status).HasColumnName("status");
            Property(t => t.JobId).HasColumnName("hrjbskr_srl");
            Property(t => t.FirstNameEnglish).HasColumnName("l_name");
            Property(t => t.LastNameEnglish).HasColumnName("l_family");
            Property(t => t.IdNumber).HasColumnName("id_no");
            Property(t => t.BirthDate).HasColumnName("birth_date");
            Property(t => t.Gender).HasColumnName("sex");
            Property(t => t.IssuanceCityId).HasColumnName("pucitys_srl_issuance");
            Property(t => t.BirthPlaceCityId).HasColumnName("pucitys_srl");
            Property(t => t.MarriageDate).HasColumnName("marriage_date");
            Property(t => t.Address).HasColumnName("address");
            Property(t => t.PhoneNumber).HasColumnName("phone_number");
            Property(t => t.MobileNumber).HasColumnName("mobile_number");
            Property(t => t.InjuriesPercentage).HasColumnName("injuries_prcnt");
            Property(t => t.HousingType).HasColumnName("housing_type");
            Property(t => t.InsuranceType).HasColumnName("summa");
            Property(t => t.BloodType).HasColumnName("blood_type");
            Property(t => t.MaritalStatus).HasColumnName("marital_status");
            Property(t => t.ReligionType).HasColumnName("religion_type");
            Property(t => t.SoldierType).HasColumnName("soldier_type");
            Property(t => t.IsMartyrFamily).HasColumnName("martyr");
            Property(t => t.IsMartyrChild).HasColumnName("shahed");
            Property(t => t.FrontDuration).HasColumnName("front_duration");
            Property(t => t.BondageDuration).HasColumnName("bondage_duration");
            Property(t => t.FrontFrequency).HasColumnName("front_continuous");
            Property(t => t.PostalCode).HasColumnName("postal_code");
            Property(t => t.NationalCode).HasColumnName("meli_code");
            Property(t => t.IdSerialNumber).HasColumnName("id_serial_no");
            Property(t => t.Picture).HasColumnName("picture");

            Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            Property(t => t.CreationTime).HasColumnName("CreationTime");
            Property(t => t.CreatorUserId).HasColumnName("CreatorUserId");
            Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            Property(t => t.LastModifierUserId).HasColumnName("LastModifierUserId");
            Property(t => t.DeletionTime).HasColumnName("DeletionTime");
            Property(t => t.DeleterUserId).HasColumnName("DeleterUserId");

            //HasOptional(x => x.Job).WithMany().HasForeignKey(x => x.JobId);

        }
    }

}