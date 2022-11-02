using System.ComponentModel.DataAnnotations;
using Takoha.Core.LaneAggregate;

namespace Takoha.Web.ApiModels;
public class ToDoItemDTO
{
  public int Id { get; set; }
  [Required]
  public string? Title { get; set; }
  public string? Description { get; set; }
  public bool IsDone { get; private set; }

  public static ToDoItemDTO FromToDoItem(LaneAvailablePeriod item)
  {
    return new ToDoItemDTO()
    {
      Id = item.Id,
    };
  }
}
