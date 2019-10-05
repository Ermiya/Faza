using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.PMS.Shared.Models
{
    //HRTIMEDT
    public class TimePerformanceItemAddDto:BaseDto
    {
        ///<summary>
        ///سريال کارکرد
        ///</summary>
        public int Serial { get; set; }

        ///<summary>
        ///کد عنوان کارکرد
        ///</summary>
        public short TitleCode { get; set; }

        ///<summary>
        ///مقدار ساعت کارکرد
        ///</summary>
        public int HourTime { get; set; }

        ///<summary>
        ///مقدار دقيقه کارکرد
        ///</summary>
        public short MinuteTime { get; set; }


    }
}