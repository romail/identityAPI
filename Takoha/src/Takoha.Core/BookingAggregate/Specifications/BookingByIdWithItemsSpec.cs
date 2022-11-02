using Ardalis.Specification;
using Takoha.Core.BookingAggregate;

namespace Takoha.Core.BookingAggregate.Specifications;
public class BookingByIdWithItemsSpec : Specification<Booking>, ISingleResultSpecification
{
  public BookingByIdWithItemsSpec(int projectId)
  {
    Query
        .Where(project => project.Id == projectId)
        .Include(project => project.Items);
  }
}
