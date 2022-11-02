using System;
using Ardalis.GuardClauses;
using Takoha.SharedKernel;
using Takoha.SharedKernel.Interfaces;

namespace Takoha.Core.VanueAggregate
{
  public class Vanue : EntityBase, IAggregateRoot
  {
    public Vanue(string title, string description)
    {
      Title = Guard.Against.NullOrEmpty(title, nameof(title));
      Description = Guard.Against.NullOrEmpty(description, nameof(description));
    }

    public string Title { get; set; }
    
    public string Description { get; set; }

    public decimal Price { get; set; }
    
    public decimal Discount { get; set; }
    
    
    private List<Lane> _items = new List<Lane>();
    public IEnumerable<Lane> Items => _items.AsReadOnly();
  }
}

