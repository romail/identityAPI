using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Takoha.Core.BookingAggregate;
using Takoha.Core.BookingAggregate.Specifications;
using Takoha.SharedKernel.Interfaces;
using Takoha.Web.ApiModels;

namespace Takoha.Web.Api;

[Authorize]
public class BookingController : BaseApiController
{
  private readonly IRepository<Booking> _repository;

  public BookingController(IRepository<Booking> repository)
  {
    _repository = repository;
  }

  // GET: api/Booking
  [HttpGet]
  public async Task<IActionResult> List()
  {
    return Ok("ok");
  }

  // GET: api/Booking/{id:int}
  [HttpGet("{id:int}")]
  public async Task<IActionResult> GetById(int id)
  {
    return Ok();
  }

  // POST: api/Booking
  [HttpPost]
  public async Task<IActionResult> Post([FromBody] CreateBookingDTO request)
  {
    var newProject = new Booking(request.Name, request.Name, request.Name);
   
    return Ok();
  }

  // PATCH: api/Booking/{bookingId}/complete/{itemId}
  [HttpPatch("{bookingId:int}/complete/{itemId}")]
  public async Task<IActionResult> Complete(int bookingtId, int itemId)
  {
    return Ok();
  }
}
