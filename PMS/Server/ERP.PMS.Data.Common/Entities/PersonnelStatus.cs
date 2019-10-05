using Bitspco.Framework.Domain.Entities;
using Bitspco.Framework.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using ERP.PMS.Shared.Enums;

namespace ERP.PMS.Common.Entities
{
    [Table("HREDUSTT")]
    public class PersonnelStatus:Entity, IAudited
    {
        ///<summary>
        ///شماره پرسنلي
        ///</summary>
        public int PersonnelId { get; set; }

        public virtual Personnel Personnel { get; set; }

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
    
        
    public class PersonnelStatusConfig : EntityTypeConfiguration<PersonnelStatus>
    {
        public PersonnelStatusConfig()
        {
            ToTable("HREDUSTT").HasKey(p => p.Id);
            Property(t => t.PersonnelId).HasColumnName("hrprsnl_srl");
            Property(t => t.StartDate).HasColumnName("start_date");
            Property(t => t.EndDate).HasColumnName("end_date");
            Property(t => t.EducationType).HasColumnName("education_type");
            Property(t => t.UniversityName).HasColumnName("university_name");
            Property(t => t.FieldName).HasColumnName("field_name");
            Property(t => t.Orientation).HasColumnName("trend_name");
            Property(t => t.Average).HasColumnName("averag");
            Property(t => t.Status).HasColumnName("status");

            Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            Property(t => t.CreationTime).HasColumnName("CreationTime");
            Property(t => t.CreatorUserId).HasColumnName("CreatorUserId");
            Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            Property(t => t.LastModifierUserId).HasColumnName("LastModifierUserId");
            Property(t => t.DeletionTime).HasColumnName("DeletionTime");
            Property(t => t.DeleterUserId).HasColumnName("DeleterUserId");

            //HasOptional(x => x.Personnel).WithMany().HasForeignKey(x => x.PersonnelId);

        }
    }
}