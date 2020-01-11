using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities.Account;

namespace Store.Data.Mapping.Account
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
                //.IsRequired(false)
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

            builder.HasData(
                new List<Address>() { new Address()
                {
                    City = "Brasília",
                    Complement = null,
                    Country = "Brasil",
                    Id = 1,
                    Neighborhood = "Taguatinga",
                    Number = 25,
                    State = "DF",
                    ZipCode = "72115030",
                    Street = "QNB 03",
                    PersonId = 1
                },
                new Address()
                {
                    City = "Brasilia",
                    Complement = "You Life Style, ap 309",
                    Country = "Brasil",
                    Id = 2,
                    Neighborhood = "Aguas Claras",
                    Number = 18,
                    State = "DF",
                    Street = "Av araucarias",
                    ZipCode = "71153-410",
                    PersonId = 2
                },


                });

        }
    }
}
