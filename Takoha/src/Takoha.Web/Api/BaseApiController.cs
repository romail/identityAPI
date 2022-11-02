using Microsoft.AspNetCore.Mvc;

namespace Takoha.Web.Api;

[Route("api/[controller]")]
[ApiController]
public abstract class BaseApiController : Controller
{
}
