using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson04.Controllers;

namespace Lesson04.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void IndexOutputs1To10FizzBuzz()
        {
            // arrange
            var controller = new HomeController();

            // act
            var output = controller.Index();

            // assert
            Assert.AreEqual("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz", 
                output);
        }

        [TestMethod]
        public void IndexOutputs1To15FizzBuzz()
        {
            // arrange
            var controller = new HomeController();

            // act
            var output = controller.Index(15);

            // assert
            Assert.AreEqual("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz",
                output);
        }
    }
}
