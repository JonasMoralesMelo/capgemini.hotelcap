using HotelTDD.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelTDD.Infra.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Clients>
    {
        public void Configure(EntityTypeBuilder<Clients> builder)
        {
            builder.ToTable("Clients");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                   .IsRequired()
                   .HasMaxLength(500);

            builder.Property(e => e.CPF)
                   .IsRequired();

            builder.Property(e => e.Hashs)
                   .IsRequired();
        }
    }
}
