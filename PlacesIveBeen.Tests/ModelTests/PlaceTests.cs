using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesIveBeen.Models;

namespace PlacesIveBeen.Tests
{
  [TestClass]
  public class PlaceTests
  {
    [TestMethod]
    public void TestName_Description_Output()
    {
      //Place testPlace = new Place();
      int testPlace = 1;
      Assert.AreEqual(typeof(Place), testPlace.GetType());
    }
  }
}

// [TestMethod]
//     public void ItemConstructor_CreatesInstanceOfItem_Item()
//     {
//       Item newItem = new Item("test");
//       Assert.AreEqual(typeof(Item), newItem.GetType());
//     }