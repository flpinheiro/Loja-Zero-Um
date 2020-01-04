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

            builder.HasKey(p=>p.Id);

            builder.Property(p => p.Number)
                .IsRequired()
                .HasColumnName("number");

            builder.Property(p => p.CountryCode)
                .IsRequired()
                .HasColumnName("country_code");

            builder.Property(p => p.AreaCode)
                .IsRequired(false)
                .HasColumnName("area_code");
        }
    }
}
