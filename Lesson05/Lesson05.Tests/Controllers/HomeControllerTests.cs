using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using Lesson05.Controllers;

namespace Lesson05.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Index1to10FizzBuzz()
        {
            // arrange
            var controller = new HomeController();
            var fizzBuzz = new FizzBuzz();

            // act
            var result = (ViewResult)controller.Index();
            var model = (IEnumerable<string>)result.Model;

            // assert
            Assert.IsTrue(model.SequenceEqual(fizzBuzz.Generate(10)));
        }

        [TestMethod]
        public void Index1to15FizzBuzz()
        {
            // arrange
            var controller = new HomeController();
            var fizzBuzz = new FizzBuzz();

            // act
            var result = (ViewResult)controller.Index(15);
            var model = (IEnumerable<string>)result.Model;

            // assert
            Assert.IsTrue(model.SequenceEqual(fizzBuzz.Generate(15)));
        }
    }
}
