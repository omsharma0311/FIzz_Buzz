using FIzz_Buzz;
using NUnit.Framework;

namespace FizzBuzzUnitTests
{
    [TestFixture]
    public class FizzBuzzUnitTest
    {
        
        [TestCase("Fizz",3)]
        [TestCase("Fizz",6)]
        [TestCase("Buzz",5)]
        [TestCase("Buzz",10)]
        [TestCase("FizzBuzz", 15)]
        [TestCase("FizzBuzz", 30)]
        [TestCase("", 7)]
        public void FizzBuzzUnitTests(string output, int input)
        {
            //ARRANGE
            FizzBuzz obj = new FizzBuzz();

            //ACT
            string result = obj.Calculate(input);

            //ASSERT
            Assert.AreEqual(output,result);
        }
    }
}