using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Takoha.Core.BookingAggregate;

namespace Takoha.Infrastructure.Data.Config;
public class BookingConfiguration : IEntityTypeConfiguration<Booking>
{
  public void Configure(EntityTypeBuilder<Booking> builder)
  {
    builder.Property(p => p.Name)
        .HasMaxLength(200)
        .IsRequired();

    builder.Property(p => p.Description)
    .HasMaxLength(100)
    .IsRequired();

  }
}
