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
    [Table("HRJOBSTT")]
    public class Job:Entity, IAudited
    {
        
        ///<summary>
        ///سريال شغل
        ///</summary>
        public int Serial { get; set; }

        ///<summary>
        ///کد شغل تامين اجتماعي
        ///</summary>
        public string JobCode { get; set; }

        ///<summary>
        ///عنوان
        ///</summary>
        public string Title { get; set; }

        ///<summary>
        ///رسته شغلي
        ///</summary>
        public short JobType { get; set; }

        ///<summary>
        ///پست سرپرستي
        ///</summary>
        public bool IsSupervisor { get; set; }

        ///<summary>
        ///
        ///</summary>
        public GeneralStatus Status { get; set; }

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
        
        public virtual IList<Personnel> Personnels { get; set; }
        public virtual IList<SalaryContract> SalaryContracts { get; set; }

        #endregion

    }
    
    public class JobConfig : EntityTypeConfiguration<Job>
    {
        public JobConfig()
        {
            ToTable("HRJOBSTT").HasKey(p => p.Id);
            Property(t => t.Serial).HasColumnName("srl");
            Property(t => t.JobCode).HasColumnName("job_code");
            Property(t => t.Title).HasColumnName("title");
            Property(t => t.JobType).HasColumnName("job_type");
            Property(t => t.IsSupervisor).HasColumnName("supervisor");
            Property(t => t.Status).HasColumnName("status");

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