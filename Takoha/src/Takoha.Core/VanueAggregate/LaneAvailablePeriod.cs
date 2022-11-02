using Takoha.Core.BookingAggregate;
using Takoha.Core.BookingAggregates.Events;
using Takoha.Core.VanueAggregate;
using Takoha.SharedKernel;

namespace Takoha.Core.LaneAggregate;

public class LaneAvailablePeriod : EntityBase
{
  public bool IsBooked { get; private set; }
  
  public Duration Duration { get; private set; }
  
  public Lane Lane { get; private set; }

  public void MarkBooked()
  {
    if (!IsBooked)
    {
      IsBooked = true;

      RegisterDomainEvent(new ToDoItemCompletedEvent(this));
    }
  }

  public override string ToString()
  {
    string status = IsBooked ? "Booked!" : "Free.";
    return $"{Id}: Status: {status}";
  }
}
