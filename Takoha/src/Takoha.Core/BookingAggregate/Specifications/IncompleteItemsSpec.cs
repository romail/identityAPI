using Ardalis.Specification;
using Takoha.Core.LaneAggregate;

namespace Takoha.Core.BookingAggregates.Specifications;
public class IncompleteItemsSpec : Specification<LaneAvailablePeriod>
{
  public IncompleteItemsSpec()
  {
    Query.Where(item => !item.IsBooked);
  }
}
