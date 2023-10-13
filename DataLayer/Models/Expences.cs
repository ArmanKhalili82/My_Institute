using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Expences
    {
        [Key]
        public int ExpencesId { get; set; }

        [Display(Name = "نوع هزینه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string ExpencesType { get; set; }
        public string ExpencesName { get; set;}
    }
}
