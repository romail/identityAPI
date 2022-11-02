using System.Collections.Generic;

namespace Takoha.Web.ViewModels;
public class BookingViewModel
{
  public int Id { get; set; }
  public string? Name { get; set; }
  public List<ToDoItemViewModel> Items = new();
}
