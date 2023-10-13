using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Fee
    {
        [Key]
        public int FeeId { get; set; }

        [Display(Name = "تاریخ پرداخت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public DateOnly DatePay { get; set; }

        public virtual PayType PayType { get; set; }

        public virtual List<StudentsRegister> StudentsRegister { get; set;}

        public Fee()
        {
            
        }
    }
}
