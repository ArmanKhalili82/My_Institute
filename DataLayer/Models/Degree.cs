using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Degree
    {
        [Key]
        public int DegreeId { get; set; }

        
        [Display(Name = "پایه تحصیلی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string DegreeName { get; set; }

        public virtual ClassNumber ClassNumber { get; set; }
        public virtual EducationYear EducationYear { get; set; }
        public virtual Cources Cources { get; set; }

        public Degree()
        { 
        
        }



    }
}
