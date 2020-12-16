using Microsoft.AspNetCore.Mvc;
using PlacesIveBeen.Models;

namespace PlacesIveBeen.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}