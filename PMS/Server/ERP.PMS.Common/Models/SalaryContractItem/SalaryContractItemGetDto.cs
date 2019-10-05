using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.PMS.Shared.Models
{
    /// <summary>
    /// اقلام حكم اداري
    /// </summary>
    //HRSLRDLT
    public class SalaryContractItemGetDto:BaseDto
    {
        ///<summary>
        ///
        ///</summary>
        public int SalaryContractId { get; set; }

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

       public bool IsDeleted { get; set; }
       public DateTime CreationTime { get; set; }
       public long? CreatorUserId { get; set; }
       public DateTime? LastModificationTime { get; set; }
       public long? LastModifierUserId { get; set; }
       public DateTime? DeletionTime { get; set; }
       public long? DeleterUserId { get; set; }
    }
}