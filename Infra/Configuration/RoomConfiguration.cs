using HotelTDD.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelTDD.Infra.Configuration
{
    public class RoomConfiguration : IEntityTypeConfiguration<Rooms>
    {
        public void Configure(EntityTypeBuilder<Rooms> builder)
        {
            builder.ToTable("Rooms");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.BuildingFloor)
                   .IsRequired()
                   .HasMaxLength(5);

            builder.Property(e => e.RoomNum)
                   .IsRequired()
                   .HasMaxLength(3);

            builder.Property(e => e.Situation)
                   .IsRequired()
                   .HasMaxLength(1);

            builder
                .HasOne(e => e.TypeRoom)
                .WithMany()
                .HasForeignKey(e => e.TypeRoomId);
        }
    }
}
