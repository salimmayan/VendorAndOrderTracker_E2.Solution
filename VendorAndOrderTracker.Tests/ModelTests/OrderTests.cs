using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  // public class OrderTest : IDisposable
   public class OrderTest
  {

    // public void Dispose()
    // {
    //   Order.ClearAll();
    // }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test Order", "Crossant order", 35);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Trial Order";
      string title = "Crossant order";
      int price = 35;
      Order newOrder = new Order(description, title, price);

      //Act
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Trial Order";
      string title = "Crossant order";
      int price = 35;
      Order newOrder = new Order(description, title, price);

      //Act
      string updatedDescription = "Real order";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;


      //Assert
     Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      //Arrange
      string description = "Trial Order";
      string title = "Crossant order";
      int price = 35;
      Order newOrder = new Order(description, title, price);

      //Act
      int result = newOrder.Price;

      //Assert
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetPrice_SetPrice_Int()
    {
      //Arrange
      string description = "Trial Order";
      string title = "Crossant order";
      int price = 35;
      Order newOrder = new Order(description, title, price);

      //Act
      int updatedPrice = 45;
      newOrder.Price = updatedPrice;
      int result = newOrder.Price;


      //Assert
     Assert.AreEqual(updatedPrice, result);
    }


  }
}