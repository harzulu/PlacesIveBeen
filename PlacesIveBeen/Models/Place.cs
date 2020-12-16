using System.Collections.Generic;

namespace PlacesIveBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }

    public Place(string cityName)
    {
      CityName = cityName;
      //_instances.Add(this);
    }
    /*
    private static List<Place> _instances = new List<Place> {};


    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
*/
  }
}