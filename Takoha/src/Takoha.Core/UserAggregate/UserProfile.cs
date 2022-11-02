using System;
using Ardalis.GuardClauses;
using System.Xml.Linq;
using Takoha.SharedKernel;

namespace Takoha.Core.UserAggregate
{
  public class UserProfile : EntityBase
  {
    public UserProfile(string phoneNumber)
    {
      PhoneNumber = Guard.Against.NullOrEmpty(phoneNumber, nameof(phoneNumber));
    }

    public string PhoneNumber { get; set; }

  }
}

