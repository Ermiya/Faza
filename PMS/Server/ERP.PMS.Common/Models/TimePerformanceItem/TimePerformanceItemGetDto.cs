using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.PMS.Shared.Models
{
    //HRTIMEDT
    public class TimePerformanceItemGetDto:BaseDto
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


        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public long? DeleterUserId { get; set; }

    }
}