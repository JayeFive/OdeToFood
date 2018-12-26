using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OdeToFood;
using OdeToFood.Controllers;

namespace OdeToFood.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var controller = new HomeController();
            var expected = "This is for unit testing";

            // Act
            var result = controller.Index() as ViewResult;
            var actual = result.ViewBag.Message;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result.Model);
        }
    }
}
