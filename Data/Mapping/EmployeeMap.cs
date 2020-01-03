using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.DependencyInjection;
using Store.Domain.Entities.Users;

namespace Store.Data.Mapping
{
    internal class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("employee");

            builder.HasBaseType<Person>();

            builder.HasKey(e => e.Id);


            builder.Property(e => e.Registration)
                .IsRequired()
                .HasColumnName("registration");

            builder.Property(e => e.Salary)
                .IsRequired()
                .HasColumnName("salary");
        }
    }
}
