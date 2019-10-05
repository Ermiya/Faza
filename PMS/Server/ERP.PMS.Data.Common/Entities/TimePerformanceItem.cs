using Bitspco.Framework.Domain.Entities;
using Bitspco.Framework.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ERP.PMS.Common.Entities
{
    [Table("HRTIMEDT")]
    public class TimePerformanceItem:Entity, IAudited
    {
        ///<summary>
        ///سريال کارکرد
        ///</summary>
        public int Serial { get; set; }

        ///<summary>
        ///کد عنوان کارکرد
        ///</summary>
        public short TitleCode { get; set; }

        ///<summary>
        ///مقدار ساعت کارکرد
        ///</summary>
        public int HourTime { get; set; }

        ///<summary>
        ///مقدار دقيقه کارکرد
        ///</summary>
        public short MinuteTime { get; set; }


        #region Audithing

       public bool IsDeleted { get; set; }
       public DateTime CreationTime { get; set; }
       public long? CreatorUserId { get; set; }
       public DateTime? LastModificationTime { get; set; }
       public long? LastModifierUserId { get; set; }
       public DateTime? DeletionTime { get; set; }
       public long? DeleterUserId { get; set; }

        #endregion

    }
    
    
    public class TimePerformanceItemConfig : EntityTypeConfiguration<TimePerformanceItem>
    {
        public TimePerformanceItemConfig()
        {
            ToTable("HRTIMEDT").HasKey(p => p.Id);
            Property(p => p.Serial ).HasColumnName("hrtimem_srl");
            Property(p => p.TitleCode ).HasColumnName("time_title_code");
            Property(p => p.HourTime ).HasColumnName("hour_time");
            Property(p => p.MinuteTime ).HasColumnName("minute_time");

            Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            Property(t => t.CreationTime).HasColumnName("CreationTime");
            Property(t => t.CreatorUserId).HasColumnName("CreatorUserId");
            Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            Property(t => t.LastModifierUserId).HasColumnName("LastModifierUserId");
            Property(t => t.DeletionTime).HasColumnName("DeletionTime");
            Property(t => t.DeleterUserId).HasColumnName("DeleterUserId");
        }
    }
}