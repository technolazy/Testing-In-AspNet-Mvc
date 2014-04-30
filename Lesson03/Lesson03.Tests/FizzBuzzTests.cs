using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson03;
using System.Linq;

namespace Lesson03.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void FirstValueIsOne()
        {
            // arrange
            var fizzBuzz = new FizzBuzz();

            // act
            var values = fizzBuzz.Generate();

            // assert
            Assert.AreEqual("1", values.First());
        }

        [TestMethod]
        public void SecondValueIsTwo()
        {
            // arrange
            var fizzBuzz = new FizzBuzz();

            // act
            var values = fizzBuzz.Generate();

            // assert
            Assert.AreEqual("2", values.Skip(1).First());
        }

        [TestMethod]
        public void ThirdValueIsFizz()
        {
            // arrange
            var fizzBuzz = new FizzBuzz();

            // act
            var values = fizzBuzz.Generate();

            // assert
            Assert.AreEqual("Fizz", values.Skip(2).First());
        }

        [TestMethod]
        public void FifthValueIsBuzz()
        {
            // arrange
            var fizzBuzz = new FizzBuzz();

            // act
            var values = fizzBuzz.Generate();

            // assert
            Assert.AreEqual("Buzz", values.Skip(4).First());
        }

        [TestMethod]
        public void FifteenthValueIsFizzBuzz()
        {
            // arrange
            var fizzBuzz = new FizzBuzz();

            // act
            var values = fizzBuzz.Generate();

            // assert
            Assert.AreEqual("FizzBuzz", values.Skip(14).First());
        }

        [TestMethod]
        public void GenerateCorrectAmount()
        {
            // arrange
            var fizzBuzz = new FizzBuzz();

            // act
            var values = fizzBuzz.Generate(100);

            // assert
            Assert.AreEqual(100, values.Count());
        }
    }
}
