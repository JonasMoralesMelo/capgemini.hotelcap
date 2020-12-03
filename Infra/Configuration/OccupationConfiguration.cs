using HotelTDD.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelTDD.Infra.Configuration
{
    public class OccupationConfiguration : IEntityTypeConfiguration<Occupations>
    {
        public void Configure(EntityTypeBuilder<Occupations> builder)
        {
            builder.ToTable("Occupations");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.DailyAmount)
                   .IsRequired();

            builder.Property(e => e.Date)
                   .IsRequired();

            builder.Property(e => e.Situation)
                   .IsRequired()
                   .HasMaxLength(1);

            builder
                    .HasOne(e => e.Client)
                    .WithMany()
                    .HasForeignKey(e => e.ClientId);

            builder
                    .HasOne(e => e.Rooms)
                    .WithMany()
                    .HasForeignKey(e => e.RoomId);
        }
    }
}

