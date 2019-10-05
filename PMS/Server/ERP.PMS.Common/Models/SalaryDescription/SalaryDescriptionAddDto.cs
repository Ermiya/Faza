using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.PMS.Shared.Models
{
    //HRSLRDST
    public class SalaryDescriptionAddDto:BaseDto
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
    }
}