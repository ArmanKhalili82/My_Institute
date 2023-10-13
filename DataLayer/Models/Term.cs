using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Term
    {
        [Key]
        public int TermId { get; set; }

        public int EducationYearId { get; set; }

        [Display(Name = "ترم تحصیلی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string TermsName { get; set; }

        public virtual EducationYear EducationYear { get; set; }

        public Term()
        {
            
        }
    }
}
