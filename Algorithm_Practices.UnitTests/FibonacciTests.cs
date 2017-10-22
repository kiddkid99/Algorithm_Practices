using NUnit.Framework;

namespace Algorithm_Practices.UnitTests
{
    [TestFixture]
    public class FibonacciTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(5, 5)]
        [TestCase(10, 55)]
        [TestCase(40, 102334155)]
        [TestCase(50, 12586269025)]
        public void Fibonacci_WhenCalled_ReturnCorrect(int number, double expected)
        {
            double result = Algorithm.Fibonacci(number);


            Assert.AreEqual(result, expected);
            
        }
    }
}
