using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities.Account;

namespace Store.Data.Mapping.Account
{
    internal class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            //builder.ToTable("employee");

            builder.HasBaseType<Person>();

            //builder.HasKey(e => e.Id);


            builder.Property(e => e.Registration)
                .IsRequired()
                .HasColumnName("registration");

            builder.Property(e => e.Salary)
                .IsRequired()
                .HasColumnName("salary");

            builder.HasData(new Employee()
            {
                FirstName = "Marcelle",
                LastName = "Rosa",
                Email = "mrosa@gmail.com",
                PassWord = "a mais gata",
                Birthday = new DateTime(1990,05,15),
                Id=2,
                Registration = "1234568",
                Salary = 3500m,
            });
        }
    }
}
