using Bitspco.Framework.Domain.Entities;
using Bitspco.Framework.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using ERP.PMS.Shared.Enums;
using System.Data.Entity.ModelConfiguration;

namespace ERP.PMS.Common.Entities
{
    [Table("HRSALRYT")]
    public class SalaryContract : Entity, IAudited
    {
        ///<summary>
        ///سريال قرارداد
        ///</summary>
        public int ContractId { get; set; }

        public virtual Contract Contract { get; set; }

        ///<summary>
        ///سريال حکم
        ///</summary>
        public int Serial { get; set; }

        ///<summary>
        ///سريال قسمتهاي سازماني
        ///</summary>
        public int DepartmentId { get; set; }

        ///<summary>
        ///سريال قسمت سازماني محل ماموريت
        ///</summary>
        public int DepartmentAssignment { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int JobId { get; set; }

        public virtual Job Job { get; set; }

        ///<summary>
        ///سريال پست
        ///</summary>
        public int PostId { get; set; }

        ///<summary>
        ///گروه شغلی
        ///</summary>
        public short JobGroup { get; set; }

        ///<summary>
        ///رتبه شغلی
        ///</summary>
        public short JobRank { get; set; }

        ///<summary>
        ///0 - غيرفعال،
        /// 1 - تنظيم،
        /// 2 - فعال،
        /// 3 - ابطال
        ///</summary>
        ///
        public SalaryContractStatus Status { get; set; }


        ///<summary>
        ///تاريخ فعال/غيرفعال شدن حکم
        ///</summary>
        public DateTime? ToggleActivationDate { get; set; }

        ///<summary>
        ///تاريخ ابطال حکم
        ///</summary>
        public DateTime? CancellationDate { get; set; }

        ///<summary>
        ///تاريخ اجرای حکم
        ///</summary>
        public DateTime RunDate { get; set; }

        ///<summary>
        ///سريال شرح حکم
        ///</summary>
        public short SalaryDescriptionId { get; set; }

        public virtual SalaryDescription SalaryDescription { get; set; }

        ///<summary>
        ///نوع حکم
        ///</summary>
        public short SalaryType { get; set; }

        ///<summary>
        ///نوع بيمه
        ///</summary>
        public short InsuranceType { get; set; }

        ///<summary>
        ///سريال فعال/غيرفعال کننده
        ///</summary>
        public int? ApplyUserId { get; set; }

//        [ForeignKey("ApplyUserId")] public User ApplyUser { get; set; }

        ///<summary>
        ///سريال ابطال کننده
        ///</summary>
        public int? CancellationUserId { get; set; }

        #region Auditin

        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public long? DeleterUserId { get; set; }

        #endregion
    }

    public class SalaryContractConfig : EntityTypeConfiguration<SalaryContract>
    {
        public SalaryContractConfig()
        {
            ToTable("HRSALRYT").HasKey(p => p.Id);
            Property(p => p.ContractId).HasColumnName("hrcntrc_srl");
            Property(p => p.Serial).HasColumnName("srl");
            Property(p => p.DepartmentId).HasColumnName("chdprmn_srl");
            Property(p => p.DepartmentAssignment).HasColumnName("chdprmn_srl_assign");
            Property(p => p.JobId).HasColumnName("hrjobst_srl");
            Property(p => p.PostId).HasColumnName("chpostn_srl");
            Property(p => p.JobGroup).HasColumnName("job_group");
            Property(p => p.JobRank).HasColumnName("job_rank");
            Property(p => p.Status).HasColumnName("status");
            Property(p => p.ToggleActivationDate).HasColumnName("apply_date");
            Property(p => p.CancellationDate).HasColumnName("cancel_date");
            Property(p => p.RunDate).HasColumnName("run_date");
            Property(p => p.SalaryDescriptionId).HasColumnName("hrslrds_srl");
            Property(p => p.SalaryType).HasColumnName("salary_type");
            Property(p => p.InsuranceType).HasColumnName("insurance_type");
            Property(p => p.ApplyUserId).HasColumnName("uausrid_srl_apply");
            Property(p => p.CancellationUserId).HasColumnName("uausrid_srl_cancel");


            Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            Property(t => t.CreationTime).HasColumnName("CreationTime");
            Property(t => t.CreatorUserId).HasColumnName("CreatorUserId");
            Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            Property(t => t.LastModifierUserId).HasColumnName("LastModifierUserId");
            Property(t => t.DeletionTime).HasColumnName("DeletionTime");
            Property(t => t.DeleterUserId).HasColumnName("DeleterUserId");

            //HasOptional(x => x.Contract).WithMany().HasForeignKey(x => x.ContractId);
            //HasOptional(x => x.SalaryDescription).WithMany().HasForeignKey(x => x.SalaryDescriptionId);
            //HasOptional(x => x.Job).WithMany().HasForeignKey(x => x.JobId);
        }
    }
}