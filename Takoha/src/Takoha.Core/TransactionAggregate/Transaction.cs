using Takoha.SharedKernel;
using Takoha.SharedKernel.Interfaces;

namespace Takoha.Core.BookingAggregate;

public class Transaction : EntityBase, IAggregateRoot
{
  public DateTime Date { get; set; }
  public Booking Booking { get; set; }
}
