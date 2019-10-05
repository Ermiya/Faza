using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.PMS.Shared.Models
{
    /// <summary>
    /// اقلام حكم اداري
    /// </summary>
    //HRSLRDLT
    public class SalaryContractItemAddDto:BaseDto
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
    }
}