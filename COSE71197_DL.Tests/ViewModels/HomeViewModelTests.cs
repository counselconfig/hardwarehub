namespace COSE71197_DL.Tests.ViewModels
{
    using COSE71197_DL.ViewModels;
    using System;
    using NUnit.Framework;
    using System.Collections.Generic;
    using COSE71197_DL.Models;

    [TestFixture]
    public class HomeViewModelTests
    {
        private HomeViewModel _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new HomeViewModel();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new HomeViewModel();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanSetAndGetHardwareOnSale()
        {
            var testValue = new[] { new Hardware { HardwareId = 2059184338, Name = "TestValue1526261479", Description = "TestValue265291222", Price = 240597377.46M, ImageUrl = "TestValue2087276577", ImageThumbnailUrl = "TestValue646002610", IsOnSale = true, IsInStock = false, CategoryId = 1662741298, Category = new Category { CategoryId = 1407351005, CategoryName = "TestValue1347007372", CategoryDescription = "TestValue2003954969", Hardwares = new List<Hardware>() } }, new Hardware { HardwareId = 810070226, Name = "TestValue1147200780", Description = "TestValue545992237", Price = 541038525.39M, ImageUrl = "TestValue447737943", ImageThumbnailUrl = "TestValue1458410229", IsOnSale = false, IsInStock = true, CategoryId = 797137419, Category = new Category { CategoryId = 1587997899, CategoryName = "TestValue1826678664", CategoryDescription = "TestValue976939289", Hardwares = new List<Hardware>() } }, new Hardware { HardwareId = 968735498, Name = "TestValue1582684051", Description = "TestValue946584309", Price = 1911205419.75M, ImageUrl = "TestValue213616995", ImageThumbnailUrl = "TestValue1182196353", IsOnSale = false, IsInStock = true, CategoryId = 1816425097, Category = new Category { CategoryId = 596430345, CategoryName = "TestValue142303480", CategoryDescription = "TestValue1250130419", Hardwares = new List<Hardware>() } } };
            _testClass.HardwareOnSale = testValue;
            Assert.That(_testClass.HardwareOnSale, Is.EqualTo(testValue));
        }
    }
}