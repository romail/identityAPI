using Takoha.SharedKernel;

namespace Takoha.Core.TaxeAggregate;
public class TaxeState : EntityBase
{
  public string Street { get; set; } = string.Empty;
  public string ZipCode { get; set; } = string.Empty;
}
