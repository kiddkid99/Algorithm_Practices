using NUnit.Framework;
using System.Numerics;

namespace Algorithm_Practices.UnitTests
{
    [TestFixture]
    public class FibonacciTests
    {
        [TestCase(0, "0")]
        [TestCase(1, "1")]
        [TestCase(5, "5")]
        [TestCase(10, "55")]
        [TestCase(50, "12586269025")]
        [TestCase(100, "354224848179261915075")]
        [TestCase(500, "139423224561697880139724382870407283950070256587697307264108962948325571622863290691557658876222521294125")]
        public void Fibonacci_WhenCalled_ReturnCorrect(int number, string expected)
        {
            BigInteger result = Algorithm.Fibonacci(number);

            BigInteger bigIntegerExpected = BigInteger.Parse(expected);


            Assert.AreEqual(result, bigIntegerExpected);
            
        }
    }
}
