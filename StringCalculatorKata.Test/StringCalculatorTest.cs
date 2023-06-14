using NUnit.Framework;

namespace StringCalculatorKata.Test
{
    public class StringCalculatorTest
    {
        [Test]
        public void Add_EmptyStringAsParams_ReturnsZero()
        {
            Assert.AreEqual(0, StringCalculator.Add(""));
        }

        [Test]
        public void Add_StringNumberAsParam_ReturnsNumber()
        {
            Assert.AreEqual(2, StringCalculator.Add("2"));
        }

        [Test]
        public void Add_AlphanumericStringAsParam_ReturnsNegativeOne()
        {
            Assert.AreEqual(-1, StringCalculator.Add("  fred 12 "));
        }

        [Test]
        public void Add_TwoNumbersCommaSeparated_ReturnsSum()
        {
            Assert.AreEqual(15, StringCalculator.Add("8,7"));
        }

        [Test] 
        public void Add_MoreThanTwoNumbers_ReturnsSum()
        {
            Assert.AreEqual(30, StringCalculator.Add("5,8,8,9"));
        }
    }
}
