using Bitspco.Framework.Domain.Entities;
using Bitspco.Framework.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using ERP.PMS.Shared.Enums;

namespace ERP.PMS.Common.Entities
{
    /// <summary>
    ///افراد تحت تکفل 
    /// </summary>
    [Table("HRDPNDNT")]
    public class Dependant : Entity, IAudited
    {
        ///<summary>
        ///شماره پرسنلي
        ///</summary>
        public int PersonnelId { get; set; }

        public virtual Personnel Personnel { get; set; }

        ///<summary>
        ///نام
        ///</summary>
        [Column("nam")]
        public string FirstName { get; set; }

        ///<summary>
        ///نام خانوادگي
        ///</summary>
        [Column("family")]
        public string LastName { get; set; }

        ///<summary>
        ///تاريخ اعتبار
        ///</summary>
        [Column("validity_date")]
        public DateTime? ValidityDate { get; set; }

        ///<summary>
        ///جنسیت
        ///</summary>
        [Column("sex")]
        public Gender Gender { get; set; }

        ///<summary>
        ///نسبت
        ///</summary>
        [Column("relation")]
        public DependantRelation Relation { get; set; }

        ///<summary>
        ///تاریخ تولد
        ///</summary>
        [Column("birth_date")]
        public DateTime? BirthDate { get; set; }

        ///<summary>
        ///تاریخ ازدواج
        ///</summary>
        [Column("marriage_date")]
        public DateTime? MarriageDate { get; set; }

        ///<summary>
        ///شماره شناسنامه
        ///</summary>
        [Column("id_no")]
        public string IdNumber { get; set; }

        ///<summary>
        ///نوع مدرک
        ///</summary>
        [Column("education_type")]
        public EducationType EducationType { get; set; }

        ///<summary>
        ///سريال شهر محل تولد
        ///</summary>
        [Column("pucitys_srl")]
        public int BirthPlaceCityId { get; set; }

        ///<summary>
        ///تحت تکلف
        ///</summary>
        [Column("under_shelter")]
        public bool IsDependant { get; set; }

        ///<summary>
        ///بيه تكميلي
        ///</summary>
        [Column("splmntry_insurance")]
        public bool IsSupplementaryInsured { get; set; }

        /// <summary>
        /// کد ملی
        /// </summary>
        [Column("meli_code")]
        public string NationalCode { get; set; }

        #region Auditing

        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public long? DeleterUserId { get; set; }

        #endregion
    }


    public class DependantConfig : EntityTypeConfiguration<Dependant>
    {
        public DependantConfig()
        {
            ToTable("HRDPNDNT").HasKey(p => p.Id);
            Property(t => t.PersonnelId).HasColumnName("hrprsnl_srl");
            Property(t => t.FirstName).HasColumnName("nam");
            Property(t => t.LastName).HasColumnName("family");
            Property(t => t.ValidityDate).HasColumnName("validity_date");
            Property(t => t.Gender).HasColumnName("sex");
            Property(t => t.Relation).HasColumnName("relation");
            Property(t => t.BirthDate).HasColumnName("birth_date");
            Property(t => t.MarriageDate).HasColumnName("marriage_date");
            Property(t => t.IdNumber).HasColumnName("id_no");
            Property(t => t.EducationType).HasColumnName("education_type");
            Property(t => t.BirthPlaceCityId).HasColumnName("pucitys_srl");
            Property(t => t.IsDependant).HasColumnName("under_shelter");
            Property(t => t.IsSupplementaryInsured).HasColumnName("splmntry_insurance");
            Property(t => t.NationalCode).HasColumnName("meli_code");

            Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            Property(t => t.CreationTime).HasColumnName("CreationTime");
            Property(t => t.CreatorUserId).HasColumnName("CreatorUserId");
            Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            Property(t => t.LastModifierUserId).HasColumnName("LastModifierUserId");
            Property(t => t.DeletionTime).HasColumnName("DeletionTime");
            Property(t => t.DeleterUserId).HasColumnName("DeleterUserId");

           // HasOptional(x => x.Personnel).WithMany().HasForeignKey(x => x.PersonnelId);
        }
    }
}