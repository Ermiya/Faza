using Bitspco.Framework.Domain.Entities;
using Bitspco.Framework.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ERP.PMS.Common.Entities
{
    [Table("HRTIMEMT")]
    public class TimePerformance : Entity, IAudited
    {
        ///<summary>
        ///سريال کارکرد
        ///</summary>
        public int Serial { get; set; }

        ///<summary>
        ///سال كاركرد
        ///</summary>
        public short Year { get; set; }

        ///<summary>
        ///ماه كاركرد
        ///</summary>
        public short Month { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int PersonnelId { get; set; }

        public virtual Personnel Personnel { get; set; }

        ///<summary>
        ///سال اصلاح کارکرد
        ///</summary>
        public short ModifyYear { get; set; }

        ///<summary>
        ///ماه اصلاح کارکرد
        ///</summary>
        public short ModifyMonth { get; set; }

        ///<summary>
        ///وضعيت کارکرد
        ///</summary>
        public short Status { get; set; }

        ///<summary>
        ///نوع کارکرد
        ///</summary>
        public short TimeType { get; set; }


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
    
    public class TimePerformanceConfig : EntityTypeConfiguration<TimePerformance>
    {
        public TimePerformanceConfig()
        {
            ToTable("HRTIMEMT").HasKey(p => p.Id);
            Property(p => p.Serial).HasColumnName("srl");
            Property(p => p.Year).HasColumnName("yer");
            Property(p => p.Month).HasColumnName("mon");
            Property(p => p.PersonnelId).HasColumnName("hrprsnl_srl");
            Property(p => p.ModifyYear).HasColumnName("modify_yer");
            Property(p => p.ModifyMonth).HasColumnName("modify_mon");
            Property(p => p.Status).HasColumnName("status");
            Property(p => p.TimeType).HasColumnName("time_type");

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