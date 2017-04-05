namespace LeapYear
{
    public static class LeapYearTest
    {
        public static bool isLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 100 != 0 && year % 4 == 0);
        }
    }
}
