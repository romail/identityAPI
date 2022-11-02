using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Takoha.Core.BookingAggregate;
using Takoha.Core.LaneAggregate;
using Takoha.Core.BookingAggregates;
using Takoha.Core.TaxeAggregate;
using Takoha.Core.VanueAggregate;
using Takoha.SharedKernel;
using Takoha.SharedKernel.Interfaces;

namespace Takoha.Infrastructure.Data;
public class AppDbContext : DbContext
{
  private readonly IDomainEventDispatcher? _dispatcher;

  public AppDbContext(DbContextOptions<AppDbContext> options,
    IDomainEventDispatcher? dispatcher)
      : base(options)
  {
    _dispatcher = dispatcher;
  }

  public DbSet<LaneAvailablePeriod> LaneAvailablePeriods => Set<LaneAvailablePeriod>();
  public DbSet<Booking> Booking => Set<Booking>();
  public DbSet<Lane> Lane => Set<Lane>();
  public DbSet<Duration> Duration => Set<Duration>();
  public DbSet<BookingTimeSlot> BookingTimeSlot => Set<BookingTimeSlot>();
  public DbSet<Transaction> Transaction => Set<Transaction>();
  public DbSet<Taxe> Taxe => Set<Taxe>();


  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }

  public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
  {
    int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

    if (_dispatcher == null) return result;

    var entitiesWithEvents = ChangeTracker.Entries<EntityBase>()
        .Select(e => e.Entity)
        .Where(e => e.DomainEvents.Any())
        .ToArray();

    await _dispatcher.DispatchAndClearEvents(entitiesWithEvents);

    return result;
  }

  public override int SaveChanges()
  {
    return SaveChangesAsync().GetAwaiter().GetResult();
  }
}
