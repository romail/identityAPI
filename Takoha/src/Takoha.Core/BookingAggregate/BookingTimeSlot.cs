using System;
using Takoha.Core.LaneAggregate;
using Takoha.SharedKernel;
using Takoha.SharedKernel.Interfaces;

namespace Takoha.Core.BookingAggregate
{
  public class BookingTimeSlot : EntityBase
  {
    public Booking? Booking { get; set; }

    public LaneAvailablePeriod? LaneAvailablePeriod { get; set; }

    public bool IsDone { get; set; }
  }
}

