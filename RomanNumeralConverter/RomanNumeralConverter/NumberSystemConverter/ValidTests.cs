using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeral;

namespace NumberSystemConverter
{
    [TestClass]
    public class ValidTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = RomanNumeralToArabic.Convert("M");
            Assert.AreEqual(result, 1000);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int result = RomanNumeralToArabic.Convert("IIX");
            Assert.AreEqual(result, 8);
        }
    }
}
