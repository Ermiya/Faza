using Bitspco.Framework.Domain.Entities;
using Bitspco.Framework.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ERP.PMS.Common.Entities
{
    [Table("HRWRKXPT")]
    public class WorkExperience : Entity, IAudited
    {
        ///<summary>
        /// شماره پرسنلي
        ///</summary>
        public int PersonnelId { get; set; }

        public virtual Personnel Personnel { get; set; }

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
    
    
    public class WorkExperienceConfig : EntityTypeConfiguration<WorkExperience>
    {
        public WorkExperienceConfig()
        {
            ToTable("HRWRKXPT").HasKey(p => p.Id);
            Property(p => p.PersonnelId).HasColumnName("hrprsnl_srl");
            Property(p => p.StartDate).HasColumnName("start_date");
            Property(p => p.EndDate).HasColumnName("end_date");
            Property(p => p.JobTitle).HasColumnName("job_title");
            Property(p => p.JobPlace).HasColumnName("job_place");
            Property(p => p.Duration).HasColumnName("duration");
            Property(p => p.DurationConfirm).HasColumnName("duration_confirm");
            Property(p => p.Description).HasColumnName("des");

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