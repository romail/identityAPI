using Takoha.Core.BookingAggregate;
using Takoha.Core.LaneAggregate;
using Takoha.SharedKernel;

namespace Takoha.Core.BookingAggregates.Events;
public class NewItemAddedEvent : DomainEventBase
{
  public LaneAvailablePeriod NewItem { get; set; }
  public Booking Booking { get; set; }

  public NewItemAddedEvent(Booking project,
      LaneAvailablePeriod newItem)
  {
    Booking = project;
    NewItem = newItem;
  }
}
