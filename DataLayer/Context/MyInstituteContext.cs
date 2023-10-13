using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MyInstituteContext: DbContext
    {
        public DbSet<ClassNumber> ClassNumbers { get; set; } 
        public DbSet<Cources> Cources { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<EducationYear> EducationYears { get; set;}
        public DbSet<Expences> Expences { get; set; }
        public DbSet<Fee> Fee { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Lessons> Lessons { get; set; }
        public DbSet<Reports> Reports { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<StudentsRegister> StudentsRegister { get; set;}
        public DbSet<TeachersName> TeachersName { get; set;}
        public DbSet<Term> Term { get; set; }








        
    }
}
