using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ClassNumber
    {
        [Key]
        public int ClassNumberId { get; set; }

        [Display(Name = "دانش آموزان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public int StudentId { get; set; }

        [Display(Name = "پایه تحصیلی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public int DegreeId { get; set; }

        [Display(Name = "شماره کلاس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string ClassesNumber { get; set; }

        public virtual EducationYear EducationYear { get; set; }
        public virtual Cources Cources { get; set; }

        public virtual List<Degree> Degrees { get; set; }
        public virtual List<StudentsRegister> StudentsRegisters  { get; set; }


        public ClassNumber()
        {
           
        }
    }
}
