using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Conf
{
    public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>

    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.OwnsOne(p => p.FullName, f =>
            {
                f.Property(n => n.FirstName).HasColumnName("PassFirstName")
                .HasMaxLength(30);
                f.Property(n => n.LastName).HasColumnName("PassLastName")
                .IsRequired();
            });
            //builder.HasDiscriminator<string>("IsTraveller")
            //        .HasValue<Staff>("2")
            //        .HasValue<Traveller>("1")
            //        .HasValue<Passenger>("0");
        }
    }
}
