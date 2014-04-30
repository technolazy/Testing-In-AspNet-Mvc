using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson02.Tests
{
    [TestClass]
    public class StringtUtiliesTests
    {
        [TestMethod]
        public void ReverseWordOrderReversesWords()
        {
            // arrange
            var originalString = "This is a string";

            // act
            var actualResult = StringUtilities.ReverseWordOrder(originalString);

            // assert
            Assert.AreEqual("string a is This", actualResult);
        }

        [TestMethod]
        public void ReverseWordOrderWithErraticWhitespace()
        {
            // arrange
            var originalString = "This  is   a string";

            // act
            var actualResult = StringUtilities.ReverseWordOrder(originalString);

            // assert
            Assert.AreEqual("string a is This", actualResult);
        }
    }
}
