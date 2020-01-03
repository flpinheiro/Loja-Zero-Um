using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities.Users;

namespace Store.Data.Mapping
{
    internal class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("address");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.City)
                .IsRequired()
                .HasColumnName("city");

            builder.Property(a => a.Complement)
                .IsRequired(false)
                .HasColumnName("complement");

            builder.Property(a => a.Country)
                .IsRequired()
                .HasColumnName("country");

            builder.Property(a => a.Neighborhood)
                .IsRequired(false)
                .HasColumnName("neighborhood");

            builder.Property(a => a.Number)
                .IsRequired(false)
                .HasColumnName("number");

            builder.Property(a => a.State)
                .IsRequired(false)
                .HasColumnName("state");

            builder.Property(a => a.Street)
                .IsRequired()
                .HasColumnName("street");

            builder.Property(a => a.ZipCode)
                .IsRequired()
                .HasColumnName("zip_code");

            builder.Property(a => a.PersonId)
                .IsRequired()
                .HasColumnName("person_id");

        }
    }
}
