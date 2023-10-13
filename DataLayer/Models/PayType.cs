using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PayType
    {
        [Key]
        public int PayTypeId {  get; set; }

        [Display(Name = "توع پرداخت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(20)]
        public string PayTypeName { get; set; }

        public virtual List<Fee> Fees { get; set; }

        public PayType()
        {
            
        }
    }
}
