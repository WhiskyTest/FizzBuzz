using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        private FizzBuzz.FizzBuzzService _fizzBuzz;


        public UnitTest1()
        {
            _fizzBuzz = new FizzBuzz.FizzBuzzService();
        }

        [TestMethod]
        public void PrintNumber()
        {
            Assert.AreEqual("2", _fizzBuzz.Print(2));
        }

        [TestMethod]
        public void PrintFizz()
        {
            Assert.AreEqual("Fizz", _fizzBuzz.Print(3));
        }

        [TestMethod]
        public void PrintBuzz()
        {
            Assert.AreEqual("Buzz", _fizzBuzz.Print(5));
        }

        [TestMethod]
        public void PrintFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", _fizzBuzz.Print(15));
        }

        [TestMethod]
        public void IsDivisibleBy()
        {
            Assert.AreEqual(true, _fizzBuzz.IsDivisibleBy(5, 5));
        }
    }
}
