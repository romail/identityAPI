using Ardalis.GuardClauses;
using Takoha.Core.BookingAggregate;
using Takoha.Core.TaxeAggregate;
using Takoha.Core.UserAggregate;
using Takoha.SharedKernel;
using Takoha.SharedKernel.Interfaces;

namespace Takoha.Core.BookingAggregate;
public class Booking : EntityBase, IAggregateRoot
{
  public string Name { get; private set; }
  public string Description { get; set; } = string.Empty;
  public string Title { get; private set; } = string.Empty;
  public string ImageUrl { get; private set; } = string.Empty;

  private List<BookingTimeSlot> _items = new();
  public IEnumerable<BookingTimeSlot> Items => _items.AsReadOnly();

  private List<Transaction> _itemsTransaction = new List<Transaction>();
  public IEnumerable<Transaction> ItemsTransaction => _itemsTransaction.AsReadOnly();
  public BookingTimeSlotStatus Status => _items.All(i => i.IsDone) ? BookingTimeSlotStatus.Complete : BookingTimeSlotStatus.InProgress;
  public User User { get; set; }
  public int UserId { get; set; }

  public decimal Total { get; set; }

  public Booking(string name, string description, string title )
  {
    Name = Guard.Against.NullOrEmpty(name, nameof(name));
    Description = Guard.Against.NullOrEmpty(description, nameof(Description));
    Title = Guard.Against.NullOrEmpty(title, nameof(Title));
  }
}
