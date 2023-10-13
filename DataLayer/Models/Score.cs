using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Score
    {
        [Key]
        public int ScoreId { get; set; }

        [Display(Name = "نمره")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public float Scores { get; set; }

        public virtual List<Lessons> Lessons { get; set; }

        public Score()
        {
            
        }



    }
}
