using Bitspco.Framework.Domain.Entities;
using Bitspco.Framework.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ERP.PMS.Common.Entities
{
    /// <summary>
    /// اقلام حكم اداري
    /// </summary>
    [Table("HRSLRDLT")]
    public class SalaryContractItem:Entity, IAudited
    {
        ///<summary>
        ///
        ///</summary>
        public int SalaryContractId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  virtual SalaryContract SalaryContract { get; set; }

        ///<summary>
        ///علت صدور مالي
        ///</summary>
        public int AccsisnSerail { get; set; }

        ///<summary>
        ///سریال
        ///</summary>
        public int Serial { get; set; }

        ///<summary>
        ///مبلغ
        ///</summary>
        public long Amount { get; set; }

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
    
    public class SalaryContractItemConfig : EntityTypeConfiguration<SalaryContractItem>
    {
        public SalaryContractItemConfig()
        {
            ToTable("HRSLRDLT").HasKey(p => p.Id);
            Property(p => p.SalaryContractId ).HasColumnName("hrsalry_srl");
            Property(p => p.AccsisnSerail ).HasColumnName("accsisn_srl");
            Property(p => p.Serial ).HasColumnName("srl");
            Property(p => p.Amount ).HasColumnName("amount");

            Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            Property(t => t.CreationTime).HasColumnName("CreationTime");
            Property(t => t.CreatorUserId).HasColumnName("CreatorUserId");
            Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            Property(t => t.LastModifierUserId).HasColumnName("LastModifierUserId");
            Property(t => t.DeletionTime).HasColumnName("DeletionTime");
            Property(t => t.DeleterUserId).HasColumnName("DeleterUserId");

            //HasOptional(x => x.SalaryContract).WithMany().HasForeignKey(x => x.SalaryContractId);

        }
    }
}