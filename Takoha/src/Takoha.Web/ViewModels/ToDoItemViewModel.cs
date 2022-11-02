using Takoha.Core.LaneAggregate;

namespace Takoha.Web.ViewModels;
public class ToDoItemViewModel
{
  public int Id { get; set; }
  public string? Title { get; set; }
  public string? Description { get; set; }
  public bool IsDone { get; private set; }

  public static ToDoItemViewModel FromToDoItem(LaneAvailablePeriod item)
  {
    return new ToDoItemViewModel()
    {
      Id = item.Id,
    };
  }
}
