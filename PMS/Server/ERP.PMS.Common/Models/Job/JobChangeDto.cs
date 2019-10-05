using System;
using System.ComponentModel.DataAnnotations.Schema;
using ERP.PMS.Shared.Enums;

namespace ERP.PMS.Shared.Models
{
    //HRJOBSTT
    public class JobChangeDto:BaseDto
    {
        ///<summary>
        ///سريال شغل
        ///</summary>
        public int Serial { get; set; }

        ///<summary>
        ///کد شغل تامين اجتماعي
        ///</summary>
        public string JobCode { get; set; }

        ///<summary>
        ///عنوان
        ///</summary>
        public string Title { get; set; }

        ///<summary>
        ///رسته شغلي
        ///</summary>
        public short JobType { get; set; }

        ///<summary>
        ///پست سرپرستي
        ///</summary>
        public bool IsSupervisor { get; set; }

        public GeneralStatus Status { get; set; }


    }
}