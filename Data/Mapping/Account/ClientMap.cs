using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities.Account;

namespace Store.Data.Mapping.Account
{
    internal class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            //builder.ToTable("client");

            builder.HasBaseType<Person>();

            //builder.HasKey(c => c.Id);

            builder.HasData(new Client()
            {
                FirstName = "Felipe Luís",
                LastName = "Pinheiro",
                Email = "Flpinheiro@gmail.COM",
                PassWord = "12345678",
                Birthday = new DateTime(1985, 05, 01),
                Id = 1,

            });
        }
    }
}
