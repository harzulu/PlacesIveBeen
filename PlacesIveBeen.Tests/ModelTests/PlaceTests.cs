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
      Place testPlace = new Place("test", 0);
      Assert.AreEqual(typeof(Place), testPlace.GetType());
    }

    [TestMethod]
    public void CityName_GetGivenCityName_String()
    {
      Place testPlace = new Place("Portland", 0);
      Assert.AreEqual("Portland", testPlace.CityName);
    }

    [TestMethod]
    public void Durration_GetGivenDurration_Int()
    {
      Place testPlace = new Place("test", 8);
      Assert.AreEqual(8, testPlace.Durration);
    }
  }
}

// [TestMethod]
//     public void ItemConstructor_CreatesInstanceOfItem_Item()
//     {
//       Item newItem = new Item("test");
//       Assert.AreEqual(typeof(Item), newItem.GetType());
//     }