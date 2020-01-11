using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities.Account;

namespace Store.Data.Mapping.Account
{
    internal class PhoneMap : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.ToTable("phone");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Number)
                .IsRequired()
                .HasColumnName("number");

            builder.Property(p => p.CountryCode)
                .IsRequired()
                .HasColumnName("country_code");

            builder.Property(p => p.AreaCode)
                .IsRequired(false)
                .HasColumnName("area_code");

            builder.HasData(

                new List<Phone>()
                {
                    new Phone()
                    {
                        CountryCode = "55",
                        AreaCode = "61",
                        Number = "995599415",
                        Id = 1,
                        PersonId = 1
                    },
                    new Phone()
                    {
                        AreaCode = "61",
                        CountryCode = "55",
                        Number = "996767867",
                        Id = 2,
                        PersonId = 2
                    },
                    
                });
        }
    }
}
