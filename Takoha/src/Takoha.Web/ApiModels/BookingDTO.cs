namespace Takoha.Web.ApiModels;

public class BookingDTO : CreateBookingDTO
{
  public BookingDTO(int id, string name, List<ToDoItemDTO>? items = null) : base(name)
  {
    Id = id;
    Items = items ?? new List<ToDoItemDTO>();
  }
  public int Id { get; set; }
  public List<ToDoItemDTO> Items { get; set; }
}

public abstract class CreateBookingDTO

{
  protected CreateBookingDTO(string name)
  {
    Name = name;
  }
  public string Name { get; set; }
}
