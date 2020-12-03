using HotelTDD.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelTDD.Infra.Configuration
{
    public class TypeRoomConfiguration : IEntityTypeConfiguration<TypeRooms>
    {
        public void Configure(EntityTypeBuilder<TypeRooms> builder)
        {
            builder.ToTable("TypeRooms");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Description)
                   .IsRequired()
                   .HasMaxLength(5);

            builder.Property(e => e.Value)
                   .IsRequired();
        }
    }
}
