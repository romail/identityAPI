using Takoha.Core.BookingAggregate;
using Takoha.Core.LaneAggregate;
using Xunit;

namespace Takoha.UnitTests.Core.ProjectAggregate;
public class Project_AddItem
{
  private Booking _testProject = new Booking("some name", "some name", "some name");

  [Fact]
  public void AddsItemToItems()
  {
    var _testItem = new LaneAvailablePeriod
    {
    };

    //_testProject.AddItem(_testItem);

    //Assert.Contains(_testItem, _testProject.Items);
  }

  [Fact]
  public void ThrowsExceptionGivenNullItem()
  {
#nullable disable
    //Action action = () => _testProject.AddItem(null);
#nullable enable

    //var ex = Assert.Throws<ArgumentNullException>(action);
    //Assert.Equal("newItem", ex.ParamName);
  }
}
