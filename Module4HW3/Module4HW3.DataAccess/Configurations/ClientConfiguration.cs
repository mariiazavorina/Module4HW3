using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Module4HW4.DataAccess.Entities;

namespace Module4HW4.DataAccess.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client").HasKey(p => p.ClientId);
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(50);
            builder.Property(p => p.PhoneNumber).IsRequired();
            builder.Property(p => p.Email).IsRequired();

            builder.HasData(new List<Client>()
            {
                new Client()
                {
                    ClientId = 1,
                    FirstName = "Svetlana",
                    LastName = "Dvoryankina",
                    PhoneNumber = 380976543675,
                    Email = "svetlana.dvoryankina@nure.ua"
                },
                new Client()
                {
                    ClientId = 2,
                    FirstName = "Oleksii",
                    LastName = "Senyushkovych",
                    PhoneNumber = 380959864553,
                    Email = "a.senyushkovych@gmail.com"
                },
                new Client()
                {
                    ClientId = 3,
                    FirstName = "Mariia",
                    LastName = "Fironova",
                    PhoneNumber = 380669867552,
                    Email = "mariia177777@ukr.net"
                },
                new Client()
                {
                    ClientId = 4,
                    FirstName = "Vadym",
                    LastName = "Pratsibuda",
                    PhoneNumber = 380966884553,
                    Email = "vadympr@gmail.com"
                },
                new Client()
                {
                    ClientId = 5,
                    FirstName = "Valeriia",
                    LastName = "Savelyeva",
                    PhoneNumber = 380970580503,
                    Email = "vvs3010@mail.ru"
                },
            });
        }
    }
}
