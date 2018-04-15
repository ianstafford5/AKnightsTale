using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AKnightsTale;
using AKnightsTale.Controllers;

namespace AKnightsTale.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Leaderboard()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Leaderboard() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void GameStates()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.GameStates() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void MyScores()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.MyScores() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Dashboard()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Dashboard() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
