using Takoha.SharedKernel;

namespace Takoha.Core.BookingAggregate
{
  public class Duration : EntityBase
  {
    public WeekDay WeekDay { get; set; }
    
    public DateTime StartTime { get; set; }
    
    public DateTime EndTime { get; set; }
    
    public bool IsEnabled { get; set; }
    
    public Duration()
    {
    }
  }
}

