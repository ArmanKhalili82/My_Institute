using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Lessons
    {
        [Key]
        public int LessonsId { get; set; }

        [Display(Name = "نام درس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string LessonsName { get; set;}


        public virtual Score Score { get; set; }
        public virtual TeachersName TeachersName { get; set; }
        public virtual EducationYear EducationYear { get; set; }

        public Lessons()
        {
            
        }
    }
}
