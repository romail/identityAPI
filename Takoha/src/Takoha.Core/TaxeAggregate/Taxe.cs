using Takoha.SharedKernel.Interfaces;
using Takoha.SharedKernel;

namespace Takoha.Core.TaxeAggregate;
public class Taxe : EntityBase, IAggregateRoot
{
  public decimal TaxAmount { get; private set; }

  public TaxeState TaxeState { get; private set; }

  public Taxe()
  {
  }
  public Taxe(TaxeState taxeState, decimal taxAmount)
  {
    TaxeState = taxeState;
    TaxAmount = taxAmount;
  }
}
