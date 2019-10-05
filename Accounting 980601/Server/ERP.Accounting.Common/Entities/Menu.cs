using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ERP.Accounting.Common.Entities
{
    public partial class Menu
    {
        [Required]
        public int Id { get; set; }
        public string Url { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public int? CreatorId { get; set; }
    }
}
