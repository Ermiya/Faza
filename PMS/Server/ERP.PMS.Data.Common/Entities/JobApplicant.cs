using Bitspco.Framework.Domain.Entities;
using Bitspco.Framework.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace ERP.PMS.Common.Entities
{
    /// <summary>
    /// متقاضيان کار
    /// </summary>
    [Table("HRJBSKRT")]
    public class JobApplicant :Entity, IAudited
    {
        ///<summary>
        ///
        ///</summary>
        public int Serial { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string FirstName { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string LastName{ get; set; }

        ///<summary>
        ///
        ///</summary>
        public DateTime BirthDate { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string PhoneNumber { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string MobileNumber { get; set; }

        ///<summary>
        ///
        ///</summary>
        public short Status { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        ///نام معرف
        ///</summary>
        public string ReagentName { get; set; }

        ///<summary>
        ///حدود معدل
        ///</summary>
        public short? AvgLimit { get; set; }

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
    
        
    public class JobApplicantConfig : EntityTypeConfiguration<JobApplicant>
    {
        public JobApplicantConfig()
        {
            ToTable("HRJBSKRT").HasKey(p => p.Id);
            Property(t => t.Serial).HasColumnName("srl");
            Property(t => t.FirstName).HasColumnName("name");
            Property(t => t.LastName).HasColumnName("family");
            Property(t => t.BirthDate).HasColumnName("birth_date");
            Property(t => t.PhoneNumber).HasColumnName("phone_number");
            Property(t => t.MobileNumber).HasColumnName("mobile_number");
            Property(t => t.Status).HasColumnName("status");
            Property(t => t.Description).HasColumnName("des");
            Property(t => t.ReagentName).HasColumnName("reagent_name");
            Property(t => t.AvgLimit).HasColumnName("avg_limit");

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
