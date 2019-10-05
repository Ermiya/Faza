using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.PMS.Shared.Models
{
    //HRSLRDST
    public class SalaryDescriptionGetDto:BaseDto
    {
        ///<summary>
        ///سریال شرح حکم
        ///</summary>
        [Column("srl")]
        public short Serial{ get; set; }

        ///<summary>
        ///شرح حکم
        ///</summary>
        [Column("des")]
        public string Description { get; set; }


        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public long? DeleterUserId { get; set; }
    }
}