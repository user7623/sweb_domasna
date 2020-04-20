using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SWEB_app.Models;

namespace SWEB_app.Model
{
    public class SWEB_appContext : DbContext
    {
        public SWEB_appContext (DbContextOptions<SWEB_appContext> options)
            : base(options)
        {
        }

        public DbSet<SWEB_app.Models.Student> Student { get; set; }

        public DbSet<SWEB_app.Models.Course> Course { get; set; }

        public DbSet<SWEB_app.Models.Teacher> Teacher { get; set; }

        public DbSet<SWEB_app.Models.Enrollment> Enrollment { get; set; }

        /*protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Enrollment>()
                .HasOne<Student>(p => p.StudentID)
                .WithMany(p => p.Courses)
                .HasForeignKey(p => p.StudentID);
            builder.Entity<Enrollment>()
                .HasOne<Course>(p => p.Course)
                .WithMany(p => p.Students)
                .HasForeignKey(p => p.CourseID); 
            builder.Entity<Course>()
                .HasMany<Teacher>(p => p.Teacher)
                .WithMany(p => p.Courses)
                .HasForeignKey(p => p.TeacherID); 
            
        }*/

    }
}
