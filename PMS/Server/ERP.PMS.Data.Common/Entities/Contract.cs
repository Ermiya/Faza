using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Bitspco.Framework.Domain.Entities;
using Bitspco.Framework.Domain.Interfaces;
using ERP.PMS.Shared.Enums;

namespace ERP.PMS.Common.Entities
{
    [Table("HRCNTRCT")]
    public class Contract : Entity, IAudited
    {

        ///<summary>
        ///شماره پرسنلي
        ///</summary>
        public int PersonnelId { get; set; }

        public virtual Personnel Personnel { get; set; }

        ///<summary>
        ///سریال
        ///</summary>
        public int Serial { get; set; }

        ///<summary>
        ///تاريخ شروع
        ///</summary>
        public int StartDate { get; set; }

        ///<summary>
        ///تاريخ پايان
        ///</summary>
        public int EndDate { get; set; }

        ///<summary>
        ///سقف ساعت كاركرد
        ///</summary>
        public int OperateTimeCiel { get; set; }

        ///<summary>
        ///نوع استخدام
        ///</summary>
        public EmployType EmployType { get; set; }

        ///<summary>
        ///نوع قرارداد
        ///</summary>
        public ContractType ContractType { get; set; }

        ///<summary>
        ///وضعيت
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
        public virtual IList<SalaryContract> SalaryContracts { get; set; }
        #endregion
    }

    public class ContractConfig : EntityTypeConfiguration<Contract>
    {
        public ContractConfig()
        {
            ToTable("HRCNTRCT").HasKey(p => p.Id);
            Property(t => t.PersonnelId).HasColumnName("hrprsnl_srl");
            Property(t => t.Serial).HasColumnName("srl");
            Property(t => t.StartDate).HasColumnName("start_date");
            Property(t => t.EndDate).HasColumnName("end_date");
            Property(t => t.OperateTimeCiel).HasColumnName("ceil_operat_time");
            Property(t => t.EmployType).HasColumnName("employ_type");
            Property(t => t.ContractType).HasColumnName("contract_type");
            Property(t => t.Status).HasColumnName("status");
            
            Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            Property(t => t.CreationTime).HasColumnName("CreationTime");
            Property(t => t.CreatorUserId).HasColumnName("CreatorUserId");
            Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            Property(t => t.LastModifierUserId).HasColumnName("LastModifierUserId");
            Property(t => t.DeletionTime).HasColumnName("DeletionTime");
            Property(t => t.DeleterUserId).HasColumnName("DeleterUserId");

            //HasOptional(x=>x.Personnel).WithMany().HasForeignKey(x=>x.PersonnelId);
        }
    }
}