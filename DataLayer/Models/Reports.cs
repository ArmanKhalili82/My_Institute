using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Reports
    {
        [Key]
        public int ReportsId { get; set; }

        [Display(Name = "نوع گزارش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string ReportsName { get; set; }
    }
}
