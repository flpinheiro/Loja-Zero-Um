using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities.Account;

namespace Store.Data.Mapping.Account
{
    internal class UserMap: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");

            builder.HasKey(u => u.Id);

            //builder.HasNoDiscriminator();

            builder.HasAlternateKey(u => u.Email);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasColumnName("email");

            builder.Property(u => u.PassWord)
                .IsRequired()
                .HasColumnName("password");
        }
    }
}
