using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest
{
    /// <summary>
    /// Unit test class for the FizzBuzz method
    /// </summary>
    [TestClass]
    public class ProgramTest
    {
        /// <summary>
        /// Tests input 3 -> output "Fizz"
        /// </summary>
        [TestMethod]
        public void TestFizz3()
        {
            string result = Program.FizzBuzz(3);

            Assert.AreEqual(result, "Fizz");
        }

        /// <summary>
        /// Tests input 27 -> output "Fizz"
        /// </summary>
        [TestMethod]
        public void TestFizz27()
        {
            string result = Program.FizzBuzz(27);

            Assert.AreEqual(result, "Fizz");
        }

        /// <summary>
        /// Tests input 15 -> output "FizzBuzz"
        /// </summary>
        [TestMethod]
        public void TestFizzBuzz15()
        {
            string result = Program.FizzBuzz(15);

            Assert.AreEqual(result, "FizzBuzz");
        }

        /// <summary>
        /// Tests input 60 -> output "FizzBuzz"
        /// </summary>
        [TestMethod]
        public void TestFizzBuzz60()
        {
            string result = Program.FizzBuzz(60);

            Assert.AreEqual(result, "FizzBuzz");
        }

        /// <summary>
        /// Tests input 55 -> output "Buzz"
        /// </summary>
        [TestMethod]
        public void TestBuzz55()
        {
            string result = Program.FizzBuzz(55);

            Assert.AreEqual(result, "Buzz");
        }

        /// <summary>
        /// Tests input 35 -> output "Buzz"
        /// </summary>
        [TestMethod]
        public void TestBuzz35()
        {
            string result = Program.FizzBuzz(35);

            Assert.AreEqual(result, "Buzz");
        }
    }
}
