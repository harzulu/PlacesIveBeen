using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesIveBeen.Models;
using System;
using System.Collections.Generic;

namespace PlacesIveBeen.Tests
{
  [TestClass]
  public class PlaceTests
  {
    List<string> testList = new List<string> {"test"};

    [TestMethod]
    public void MakePlace_CreateAnInstanceOfPlace_Place()
    {
      Place testPlace = new Place("test", 0, testList);
      Assert.AreEqual(typeof(Place), testPlace.GetType());
    }

    [TestMethod]
    public void CityName_GetGivenCityName_String()
    {
      Place testPlace = new Place("Portland", 0, testList);
      Assert.AreEqual("Portland", testPlace.CityName);
    }

    [TestMethod]
    public void Durration_GetGivenDurration_Int()
    {
      Place testPlace = new Place("test", 8, testList);
      Assert.AreEqual(8, testPlace.Durration);
    }

    [TestMethod]
    public void PeopleList_GetGivenPeopleList_PeopleList()
    {
      List<string> testPeopleList = new List<string> {"person one", "person two", "person three"};
      Place testPlace = new Place("test", 0, testPeopleList);
      CollectionAssert.AreEqual(testList, testPlace.PeopleList);
    }
  }
}

// [TestMethod]
//     public void ItemConstructor_CreatesInstanceOfItem_Item()
//     {
//        List<string> people = new List<string> {"person", "", ""};
//       Item newItem = new Item("test", people);
//       Assert.AreEqual(typeof(Item), newItem.GetType());
//     }