using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeral;

namespace NumberSystemConverter
{
    [TestClass]
    public class InvalidTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod1()
        {
            RomanNumeralToArabic.Convert("H");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod2()
        {
            RomanNumeralToArabic.Convert("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod3()
        {
            RomanNumeralToArabic.Convert("Hello World!");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestMethod4()
        {
            RomanNumeralToArabic.Convert(null);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(8, RomanNumeralToArabic.Convert("IIX"));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(12, RomanNumeralToArabic.Convert("XII"));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(18, RomanNumeralToArabic.Convert("XIIX"));
        }

        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual(18, RomanNumeralToArabic.Convert("IIXX"));
        }
    }
}
