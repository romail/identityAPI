using System;
using Ardalis.GuardClauses;
using Takoha.Core.BookingAggregate;
using Takoha.Core.LaneAggregate;
using Takoha.Core.VanueAggregate;
using Takoha.SharedKernel;
using Takoha.SharedKernel.Interfaces;

namespace Takoha.Core.VanueAggregate
{
  public class Lane : EntityBase
  {
    public Lane(int laneNumber)
    {
      LaneNumber = laneNumber;
    }

    public int LaneNumber { get; private set; }
    private List<LaneAvailablePeriod> _items = new List<LaneAvailablePeriod>();
    public IEnumerable<LaneAvailablePeriod> Items => _items.AsReadOnly();

    public Vanue Vanue { get; set; }
  }
}

