using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.PMS.Shared.Models
{
    
    //HRTIMEMT
    public class TimePerformanceChangeDto:BaseDto
    {
        ///<summary>
        ///سريال کارکرد
        ///</summary>
        public int Serial { get; set; }

        ///<summary>
        ///سال كاركرد
        ///</summary>
        public short Year { get; set; }

        ///<summary>
        ///ماه كاركرد
        ///</summary>
        public short Month { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int PersonnelId { get; set; }

        ///<summary>
        ///سال اصلاح کارکرد
        ///</summary>
        public short ModifyYear { get; set; }

        ///<summary>
        ///ماه اصلاح کارکرد
        ///</summary>
        public short ModifyMonth { get; set; }

        ///<summary>
        ///وضعيت کارکرد
        ///</summary>
        public short Status { get; set; }

        ///<summary>
        ///نوع کارکرد
        ///</summary>
        public short TimeType { get; set; }

    }
}