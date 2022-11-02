using Takoha.Core.LaneAggregate;
using Takoha.Core.BookingAggregate;

namespace Takoha.UnitTests;
// Learn more about test builders:
// https://ardalis.com/improve-tests-with-the-builder-pattern-for-test-data
public class ToDoItemBuilder
{
  private LaneAvailablePeriod _todo = new LaneAvailablePeriod();

  public ToDoItemBuilder Id(int id)
  {
    _todo.Id = id;
    return this;
  }

  public ToDoItemBuilder Title(string title)
  {
    //_todo.Title = title;
    return this;
  }

  public ToDoItemBuilder Description(string description)
  {
    //_todo.Description = description;
    return this;
  }

  public ToDoItemBuilder WithDefaultValues()
  {
    _todo = new LaneAvailablePeriod() { Id = 1 };

    return this;
  }

  public LaneAvailablePeriod Build() => _todo;
}
