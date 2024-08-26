using Assignment.ConfigrationClasses;
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
            modelBuilder.Entity<Course_Inst>().HasKey(S => new { S.Inst_Id,S.Course_Id });
            //modelBuilder.Entity<Course_Inst>().HasKey(S => S.Course_Id);
            modelBuilder.Entity<Stud_Course>().HasKey(S => new { S.Stud_Id , S.Course_Id});
            //modelBuilder.Entity<Stud_Course>().HasKey(S => S.Course_Id);
            modelBuilder.Entity<Topic>()
                .HasMany(T => T.Courses)
                .WithOne(C => C.topic);
            modelBuilder.Entity<Course>()
                .HasMany(C => C.stud_Course)
                .WithOne(SC => SC.Course)
                .IsRequired(true)
                .HasForeignKey(SC => SC.Course_Id);

            modelBuilder.Entity<Course>()
            .HasMany(C => C.Course_Inst)
            .WithOne(SC => SC.Course)
            .IsRequired(true)
            .HasForeignKey(SC => SC.Course_Id);

            modelBuilder.Entity<Instructor>()
            .HasMany(I => I.Course_Inst)
            .WithOne(IC => IC.Instructor)
            .IsRequired(true)
            .HasForeignKey(SC => SC.Course_Id);

            modelBuilder.ApplyConfiguration(new DepartmentConfigurations());
            modelBuilder.ApplyConfiguration(new StudentConfigurations());

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
