using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class StudentsRegister
    {
        [Key]
        public int StudentId { get; set; }

        [Display(Name = "شهریه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public int FeeId { get; set; }

        [Display(Name = "جنسیت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public int GenderId { get; set; }

        [Display(Name = "سال تحصیلی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public int EducationYearId { get; set; }

        [Display(Name = "شماره کلاس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public int ClassNumberId { get; set; }

        [Display(Name ="کد دانش آموز")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [MaxLength(8)]
        public int StudentCode { get; set; }

        [Display(Name = "نام ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string Family { get; set; }

        [Display(Name = "نام پدر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        [DisplayName("Father Name")]
        public string FathersName { get; set; }


        [Display(Name = "کد ملی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(10)]
        public string NationalId { get; set; }

        [Display(Name = "شماره شناسنامه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string IdCard { get; set; }

        [Display(Name = "محل تولد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string BirthPlace { get; set; }

        [Display(Name = "تاریخ تولد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(10)]
        public DateOnly DateBirth { get; set; }

        [Display(Name = "سن")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string Age { get; set; }

        [Display(Name = "رشته دانش آموز")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string Education { get; set; }

        [Display(Name = "شماره تلقن")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string PhoneNumber { get; set; }

        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string CellPhone { get; set; }

        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string Address { get; set; }

        [Display(Name = "تصویر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string Img { get; set; }


        public virtual ClassNumber ClassNumber { get; set; }
        public virtual Fee Fee { get; set; }
        public virtual EducationYear EducationYear { get; set; }
        public virtual Gender Gender { get; set; }
        public StudentsRegister()
        {
            
        }
    }
}
