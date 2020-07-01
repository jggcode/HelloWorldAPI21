using HelloWorld.API.DotNetCore21.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HelloWorld.API.Tests.DotNetCore21
{
    [TestClass]
    public class ValuesControllerTests
    {
        [TestMethod]
        public void ValuesReturnsGoodMorning()
        {
            var controller = new ValuesController();
            controller.DateTime = new System.DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 4, 30, 10);
            var result = controller.Get();

            string expected = "Good morning from .Net Core 2.1! The current date and time is: 7/1/2020 4:30:10 AM";
            string actual = result.Value;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValuesReturnsGoodAfternoon()
        {
            var controller = new ValuesController();
            controller.DateTime = new System.DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 30, 10);
            var result = controller.Get();

            string expected = "Good afternoon from .Net Core 2.1! The current date and time is: 7/1/2020 2:30:10 PM";
            string actual = result.Value;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValuesReturnsGoodEvening()
        {
            var controller = new ValuesController();
            controller.DateTime = new System.DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20, 30, 10);
            var result = controller.Get();

            string expected = "Good evening from .Net Core 2.1! The current date and time is: 7/1/2020 8:30:10 PM";
            string actual = result.Value;

            Assert.AreEqual(expected, actual);
        }
    }
}
