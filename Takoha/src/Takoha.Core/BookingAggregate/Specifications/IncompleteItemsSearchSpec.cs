using Ardalis.Specification;
using Takoha.Core.LaneAggregate;

namespace Takoha.Core.BookingAggregates.Specifications;
public class IncompleteItemsSearchSpec : Specification<LaneAvailablePeriod>
{
  public IncompleteItemsSearchSpec(string searchString)
  {
    //Query
        //.Where(item => !item.IsBooked &&
        //(item.Title.Contains(searchString) ||
        //item.Description.Contains(searchString)));
  }
}
