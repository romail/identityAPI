using Microsoft.AspNetCore.Mvc;
using Takoha.Core.BookingAggregate;
using Takoha.Core.BookingAggregate.Specifications;
using Takoha.SharedKernel.Interfaces;
using Takoha.Web.ViewModels;

namespace Takoha.Web.Controllers;
[Route("[controller]")]
public class BookingController : Controller
{
  private readonly IRepository<Booking> _bookingRepository;

  public BookingController(IRepository<Booking> bookingRepository)
  {
    _bookingRepository = bookingRepository;
  }

  // GET Booking/{bookingId?}
  [HttpGet("{bookingId:int}")]
  public async Task<IActionResult> Index(int bookingId = 1)
  {
    return Ok();
  }
}
