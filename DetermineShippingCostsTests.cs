using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProftaakY3P2;

namespace ProftaakY3P2Tests
{
    [TestClass]
    public class DetermineShippingCostsTests
    {
        [TestMethod]
        public void CalculateShippingCosts_True_TotalPrice_GreaterThan1500_ReturnsZero()
        {
            // Arrange
            var determineShippingCosts = new DetermineShippingCosts();

            // Act
            var result = determineShippingCosts.ShippingCosts(true, "Ground", 1501);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CalculateShippingCosts_True_TypeOfShippingCosts_Ground_Returns100()
        {
            // Arrange
            var determineShippingCosts = new DetermineShippingCosts();

            // Act
            var result = determineShippingCosts.ShippingCosts(true, "Ground", 1499);

            // Assert
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void CalculateShippingCosts_True_TypeOfShippingCosts_InStore_Returns50()
        {
            // Arrange
            var determineShippingCosts = new DetermineShippingCosts();

            // Act
            var result = determineShippingCosts.ShippingCosts(true, "InStore", 1200);

            // Assert
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void CalculateShippingCosts_True_TypeOfShippingCosts_NextDayAir_Returns250()
        {
            // Arrange
            var determineShippingCosts = new DetermineShippingCosts();

            // Act
            var result = determineShippingCosts.ShippingCosts(true, "NextDayAir", 1200);

            // Assert
            Assert.AreEqual(250, result);
        }

        [TestMethod]
        public void CalculateShippingCosts_True_TypeOfShippingCosts_SecondDayAir_Returns125()
        {
            // Arrange
            var determineShippingCosts = new DetermineShippingCosts();

            // Act
            var result = determineShippingCosts.ShippingCosts(true, "SecondDayAir", 1200);

            // Assert
            Assert.AreEqual(125, result);
        }

        [TestMethod]
        public void CalculateShippingCosts_True_InvalidTypeOfShippingCosts_ReturnsZero()
        {
            // Arrange
            var determineShippingCosts = new DetermineShippingCosts();

            // Act
            var result = determineShippingCosts.ShippingCosts(true, "InvalidType", 1200);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CalculateShippingCosts_False_ReturnsZero()
        {
            // Arrange
            var determineShippingCosts = new DetermineShippingCosts();

            // Act
            var result = determineShippingCosts.ShippingCosts(false, "Ground", 1200);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
