using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TeachersName
    {
        [Key]
        public int TeachersId { get; set; }

        [Display(Name = "کد معلم")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public int TeachersCode { get; set; }

        [Display(Name = "نام ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string Family { get; set; }

        [Required]
        [StringLength(10)]
        [DisplayName("کد ملی")]
        public string NationalId { get; set; }

        [Display(Name = "شماره شناسنامه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string IdCard { get; set; }

        [Required]
        [DisplayName("محل تولد")]
        public string BirthPlace { get; set; }

        [Required]
        [DisplayName("تاریخ تولد")]
        public DateOnly DateBirth { get; set; }

        [Required]
        [DisplayName("سطح تحصیلات")]
        public string Education { get; set; }

        [Required]
        [DisplayName("شماره تلفن")]
        public string PhoneNumber { get; set; }

        [Required]
        [DisplayName("شماره موبایل")]
        public string CellPhone { get; set; }

        [Required]
        [DisplayName("آدرس")]
        public string Address { get; set; }

        [Required]
        [DisplayName("تصویر")]
        public string Img { get; set; }


        public virtual Gender Gender { get; set; }
        public virtual List<Lessons> Lessons { get; set; }
        public TeachersName()
        {
            
        }
    }
}
