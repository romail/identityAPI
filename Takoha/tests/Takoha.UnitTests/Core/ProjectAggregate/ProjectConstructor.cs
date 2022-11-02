using Takoha.Core.BookingAggregate;
using Xunit;

namespace Takoha.UnitTests.Core.ProjectAggregate;
public class ProjectConstructor
{
  private string _testName = "test name";
  private Booking? _testProject;

  private Booking CreateProject()
  {
    return new Booking(_testName, _testName, _testName);
  }

  [Fact]
  public void InitializesName()
  {
    _testProject = CreateProject();

    Assert.Equal(_testName, _testProject.Name);
  }

  [Fact]
  public void InitializesPriority()
  {
    _testProject = CreateProject();
  }

  [Fact]
  public void InitializesTaskListToEmptyList()
  {
    _testProject = CreateProject();

    Assert.NotNull(_testProject.Items);
  }

  [Fact]
  public void InitializesStatusToInProgress()
  {
    _testProject = CreateProject();

    //Assert.Equal(OrderStatus.Complete, _testProject.Status);
  }
}
