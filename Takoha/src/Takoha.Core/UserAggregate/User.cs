using System;
using Ardalis.GuardClauses;
using Takoha.SharedKernel;
using Takoha.SharedKernel.Interfaces;

namespace Takoha.Core.UserAggregate
{
  public class User : EntityBase, IAggregateRoot
  {
    public User(string userName, string email)
    {
      UserName = Guard.Against.NullOrEmpty(userName, nameof(userName));
      Email = Guard.Against.NullOrEmpty(email, nameof(email));
    }

    public string UserName { get; set; }
    public string Email { get; set; }
    public UserProfile UserProfile { get; set; } = null;
  }
}

