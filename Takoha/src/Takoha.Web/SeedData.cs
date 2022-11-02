using Microsoft.EntityFrameworkCore;
using Takoha.Core.BookingAggregate;
using Takoha.Core.LaneAggregate;
using Takoha.Infrastructure.Data;

namespace Takoha.Web;
public static class SeedData
{
  public static readonly Booking TestBooking = new Booking("Test Booking", "Test description", "Test title");
  public static readonly LaneAvailablePeriod period1 = new();

  public static void Initialize(IServiceProvider serviceProvider)
  {
    using (var dbContext = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>(), null))
    {
      if (dbContext.LaneAvailablePeriods.Any())
      {
        return;
      }

      PopulateTestData(dbContext);
    }
  }
  public static void PopulateTestData(AppDbContext dbContext)
  {
    foreach (var item in dbContext.Booking)
    {
      dbContext.Remove(item);
    }
    foreach (var item in dbContext.LaneAvailablePeriods)
    {
      dbContext.Remove(item);
    }
    dbContext.SaveChanges();

    dbContext.SaveChanges();
  }
}
