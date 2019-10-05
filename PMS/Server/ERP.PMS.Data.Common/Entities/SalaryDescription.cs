using Bitspco.Framework.Domain.Entities;
using Bitspco.Framework.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ERP.PMS.Common.Entities
{
    [Table("HRSLRDST")]
    public class SalaryDescription:Entity, IAudited
    {
        public virtual IList<SalaryContract> SalaryContracts { get; set; }
        ///<summary>
        ///سریال شرح حکم
        ///</summary>
        public short Serial{ get; set; }

        ///<summary>
        ///شرح حکم
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
    
    public class SalaryDescriptionConfig : EntityTypeConfiguration<SalaryDescription>
    {
        public SalaryDescriptionConfig()
        {
            ToTable("HRSLRDST").HasKey(p => p.Id);
            Property(p => p.Serial ).HasColumnName("srl");
            Property(p => p.Description ).HasColumnName("des");

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