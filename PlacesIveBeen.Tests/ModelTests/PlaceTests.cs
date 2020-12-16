using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesIveBeen.Models;

namespace PlacesIveBeen.Tests
{
  [TestClass]
  public class PlaceTests
  {
    [TestMethod]
    public void MakePlace_CreateAnInstanceOfPlace_Place()
    {
      Place testPlace = new Place("test");
      Assert.AreEqual(typeof(Place), testPlace.GetType());
    }

    [TestMethod]
    public void CityName_GetGivenCityName_String()
    {
      Place testPlace = new Place("Porkland");
      Assert.AreEqual("Portland", testPlace.CityName);
    }
  }
}

// [TestMethod]
//     public void ItemConstructor_CreatesInstanceOfItem_Item()
//     {
//       Item newItem = new Item("test");
//       Assert.AreEqual(typeof(Item), newItem.GetType());
//     }