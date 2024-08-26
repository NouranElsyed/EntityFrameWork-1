using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ConfigrationClasses
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.HasMany(D => D.Students)
                 .WithOne(S=>S.department);
            D.HasMany(D => D.Instructors)
                .WithOne(I => I.dept)
                .OnDelete(DeleteBehavior.NoAction);

            D.HasOne(D => D.Manager)
             .WithOne(I => I.department)
             .OnDelete(DeleteBehavior.NoAction);



        }
    }


}
