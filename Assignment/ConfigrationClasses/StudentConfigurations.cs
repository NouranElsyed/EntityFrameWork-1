using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ConfigrationClasses
{
    internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> S)
        {
            S.HasKey(S => S.Id);
            S.Property(S => S.Id).UseIdentityColumn(1, 1);
            S.Property(S => S.FName).HasColumnType("varchar").HasMaxLength(50).HasDefaultValue(10);
            S.HasMany(S => S.stud_Course)
                .WithOne(SC=>SC.Student)
                .IsRequired(true)
                .HasForeignKey(SC=>SC.Stud_Id);

        }
    }
}
