using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class EducationYear
    {
        [Key]
        public int EducationYearId { get; set; }

        [Display(Name = "سال تحصیلی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(20)]
        public DateOnly EducationYears { get; set; }

        public virtual List<StudentsRegister> StudentsRegister { get; set;}
        public virtual List<ClassNumber> ClassNumbers { get; set; }
        public virtual List<Degree> Degrees { get; set; }
        public virtual List<Cources> Courses { get; set; }
        public virtual List<Lessons> Lessons { get; set; }
        public virtual List<Term> Term { get; set; }

        public EducationYear()
        {
            
        }
    }
}
