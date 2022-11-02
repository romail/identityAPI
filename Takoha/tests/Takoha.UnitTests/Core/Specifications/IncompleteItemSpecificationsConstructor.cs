using Takoha.Core.LaneAggregate;
using Takoha.Core.BookingAggregates.Specifications;
using Xunit;

namespace Takoha.UnitTests.Core.Specifications;
public class IncompleteItemsSpecificationConstructor
{
  [Fact]
  public void FilterCollectionToOnlyReturnItemsWithIsDoneFalse()
  {
    var item1 = new LaneAvailablePeriod();
    var item2 = new LaneAvailablePeriod();
    var item3 = new LaneAvailablePeriod();

    var items = new List<LaneAvailablePeriod>() { item1, item2, item3 };

    var spec = new IncompleteItemsSpec();

    var filteredList = spec.Evaluate(items);

    Assert.Contains(item1, filteredList);
    Assert.Contains(item2, filteredList);
    Assert.DoesNotContain(item3, filteredList);
  }
}
