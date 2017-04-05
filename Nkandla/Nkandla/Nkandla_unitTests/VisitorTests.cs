using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SouthAfrica
{
    [TestClass]
    public class VisitorTests
    {
        Politician Helen, Julius, Cyril;

        Nkandla Home = new Nkandla() { };

        public VisitorTests()
        {
            Helen = new Politician("Helen Zille", PersonType.Politician)
            {
                age = 57,
                gender = 'F',
                politicalParty = "DA"
            };

            Julius = new Politician("Julius Malema", PersonType.Politician)
            {
                age = 43,
                gender = 'M',
                politicalParty = "EFF"
            };

            Cyril = new Politician("Cyril Ramaphosa", PersonType.Politician)
            {
                age = 197,
                gender = 'M',
                politicalParty = "ANC"
            };
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMethod1()
        {
            Home.accept(Helen);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMethod2()
        {
            Home.accept(Julius);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual($"Welcome to Nkandla, {Cyril.getName()}", Home.accept(Cyril));
        }
    }
}
