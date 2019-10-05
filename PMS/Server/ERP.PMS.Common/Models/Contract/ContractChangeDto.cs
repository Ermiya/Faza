using System;
using System.ComponentModel.DataAnnotations.Schema;
using ERP.PMS.Shared.Enums;

namespace ERP.PMS.Shared.Models
{
    //HRCNTRCT
    public class ContractChangeDto : BaseDto
    {
        ///<summary>
        ///شماره پرسنلي
        ///</summary>
        public int PersonnelId { get; set; }

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

    }
}