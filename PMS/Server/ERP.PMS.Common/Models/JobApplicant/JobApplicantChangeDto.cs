using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.PMS.Shared.Models
{
    //HRJBSKRT
    public class JobApplicantChangeDto :BaseDto
    {
        ///<summary>
        ///
        ///</summary>
        [Column("srl")]
        public int Serial { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string FirstName { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string LastName{ get; set; }

        ///<summary>
        ///
        ///</summary>
        public DateTime BirthDate { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string PhoneNumber { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string MobileNumber { get; set; }

        ///<summary>
        ///
        ///</summary>
        public short Status { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        ///نام معرف
        ///</summary>
        public string ReagentName { get; set; }

        ///<summary>
        ///حدود معدل
        ///</summary>
        public short? AvgLimit { get; set; }

        }
    }
