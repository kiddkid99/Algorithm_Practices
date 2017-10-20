using NUnit.Framework;

namespace Algorithm_Practices.UnitTests
{
    [TestFixture]
    public class FibonacciTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void Fibonacii_WhenCalled_ReturnCorrect(int number, long expected)
        {
            int result = Algorithm.Fibonacci(number);


            Assert.AreEqual(result, expected);
            
        }
    }
}
