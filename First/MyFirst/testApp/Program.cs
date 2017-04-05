using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the distance in metres:");
            Metric foo = new Metric(Console.ReadLine());
            Console.WriteLine("Please enter the time taken in hh-mm-ss format:");
            Time bar = new Time(Console.ReadLine());

            Imperial lah = new Imperial(foo.metres * 1.09361);

            Console.WriteLine(foo.getKilometresPerHour(bar) + "kph");
            Console.WriteLine(foo.getMetresPerSecond(bar) + "mps");

            Console.WriteLine(lah.getMilesPerHour(bar) + "mph");
        }
    }

    class Time
    {
        int hours;
        int minutes;
        int seconds;

        public Time(string time)
        {
            string[] splitTime = time.Split('-');

            this.hours = int.Parse(splitTime[0]);
            this.minutes = int.Parse(splitTime[1]);
            this.seconds = int.Parse(splitTime[2]);
        }

        public int totalSeconds()
        {
            return this.hours * 3600 + this.minutes * 60 + this.seconds;
        }

        public double totalHours()
        {
            return this.hours + this.minutes/60.0 + this.seconds/3600.0;
        }
    }

    class Imperial
    {
        double yards;

        public Imperial(double yards)
        {
            this.yards = yards;
        }

        public double getMiles()
        {
            return this.yards / 1760;
        }

        public double getMilesPerHour(Time time)
        {
            return this.getMiles() / time.totalHours();
        }
    }

    class Metric
    {
        public double metres;

        public Metric(string metres)
        {
            this.metres = double.Parse(metres);
        }

        public double getKilometres()
        {
            return this.metres / 1000;
        }

        public double getMetresPerSecond(Time time)
        {
            return this.metres / time.totalSeconds();
        }

        public double getKilometresPerHour(Time time)
        {
            return this.getKilometres() / time.totalHours();
        }
    }
}
