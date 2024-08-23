using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Context
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(S => S.Id);
            modelBuilder.Entity<Student>().Property(S=>S.Id).UseIdentityColumn(1,1);
            modelBuilder.Entity<Student>().Property(S => S.FName).HasColumnType("varchar").HasMaxLength(50).HasDefaultValue(10);
            modelBuilder.Entity<Course_Inst>().HasKey(S => S.Inst_Id);
            modelBuilder.Entity<Course_Inst>().HasKey(S => S.Course_Id);
            modelBuilder.Entity<Stud_Course>().HasKey(S => S.Stud_Id);
            modelBuilder.Entity<Stud_Course>().HasKey(S => S.Course_Id);



            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        =>
            optionsBuilder.UseSqlServer("Server = . ; Database = ITI_DB ; Trusted_Connection = true;TrustServerCertificate=True");

        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Inst> CoursesInstructor { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Stud_Course> StudentsCourse { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Topic> Topics { get; set; }

    }
}
