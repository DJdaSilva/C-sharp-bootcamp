using Xunit;

namespace LeapYear
{
    public class TestClass
    {
        [Fact]
        public void fact1()
        {
            Assert.True(LeapYearTest.isLeapYear(2016));
        }

        [Fact]
        public void fact2()
        {
            Assert.True(LeapYearTest.isLeapYear(2020));
        }

        [Fact]
        public void fact3()
        {
            Assert.False(LeapYearTest.isLeapYear(1900));
        }

        [Fact]
        public void fact4()
        {
            Assert.False(LeapYearTest.isLeapYear(1700));
        }

        [Fact]
        public void fact5()
        {
            Assert.False(LeapYearTest.isLeapYear(1800));
        }

        [Fact]
        public void fact6()
        {
            Assert.True(LeapYearTest.isLeapYear(1816));
        }
    }
}