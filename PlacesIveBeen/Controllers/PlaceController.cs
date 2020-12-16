using Microsoft.AspNetCore.Mvc;
using PlacesIveBeen.Models;
using System;
using System.Collections.Generic;

namespace PlacesIveBeen.Controllers
{
  public class PlaceController : Controller
  {
    [HttpGet("/place")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/place/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/place")]
    public ActionResult Create(string cityName, int durration, string peopleList1, string peopleList2, string peopleList3, string description)
    {
      List<string> people = new List<string> {peopleList1, peopleList2, peopleList3};
      Place myPlace = new Place(cityName, durration, people, description);
      return RedirectToAction("Index");
    }
  }
}