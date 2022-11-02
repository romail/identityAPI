using Takoha.Core.LaneAggregate;
using Takoha.SharedKernel;

namespace Takoha.Core.BookingAggregates.Events;

public class ToDoItemCompletedEvent : DomainEventBase
{
  public LaneAvailablePeriod CompletedItem { get; set; }

  public ToDoItemCompletedEvent(LaneAvailablePeriod completedItem)
  {
    CompletedItem = completedItem;
  }
}
