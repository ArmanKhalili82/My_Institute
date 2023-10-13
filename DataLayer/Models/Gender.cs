using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Gender
    {
        [Key]
        public int GenderId { get; set; }


        [Display(Name = "جنسیت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string GenderName { get; set; }

        public virtual List<StudentsRegister> StudentsRegister { get; set;}
        public virtual List<TeachersName> TeachersNames { get; set;}

        public Gender()
        {
            
        }


    }
}
