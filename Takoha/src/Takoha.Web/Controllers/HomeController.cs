﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Takoha.Web.ViewModels;

namespace Takoha.Web.Controllers;

public class HomeController : Controller
{
  public IActionResult Index()
  {
    return View();
  }

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}
