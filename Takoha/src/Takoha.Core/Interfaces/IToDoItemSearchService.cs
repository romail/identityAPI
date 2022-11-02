using Ardalis.Result;
using Takoha.Core.LaneAggregate;

namespace Takoha.Core.Interfaces;
public interface IToDoItemSearchService
{
  Task<Result<LaneAvailablePeriod>> GetNextIncompleteItemAsync(int projectId);
  Task<Result<List<LaneAvailablePeriod>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
}
