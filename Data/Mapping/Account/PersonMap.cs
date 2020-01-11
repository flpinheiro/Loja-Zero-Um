using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities.Account;

namespace Store.Data.Mapping.Account
{
    internal class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            //builder.ToTable("person");

            builder.HasBaseType<User>();

            //builder.HasKey(p => p.Id);

            builder.Property(p => p.FirstName)
                .IsRequired()
                .HasColumnName("first_name");

            builder.Property(p => p.LastName)
                .IsRequired()
                .HasColumnName("last_name");

            builder.Property(p => p.Birthday)
                .IsRequired()
                .HasColumnName("birth_day");

            //builder.Property(p => p.Addresses)
            //    .IsRequired();

            //builder.Property(p => p.Phones)
            //    .IsRequired();
            
            builder.HasMany(p => p.Addresses)
                .WithOne(a => a.Person)
                .HasForeignKey(a => a.PersonId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.Phones)
                .WithOne(p => p.Person)
                .HasForeignKey(p => p.PersonId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
