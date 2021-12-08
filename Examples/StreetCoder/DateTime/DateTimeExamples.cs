using System;
using NUnit.Framework;

namespace CodeKata.Examples.StreetCoder.DateTime
{
    [TestFixture]
    public class DateTimeExamples
    {
        [Test]
        public void DocsExample()
        {
            // see: https://docs.microsoft.com/en-us/dotnet/api/system.datetimeoffset.offset?view=netcore-3.1
            DateTimeOffset localTime = DateTimeOffset.Now;
            
            Console.WriteLine("The local time zone is {0} hours and {1} minutes {2} than UTC.",
                Math.Abs(localTime.Offset.Hours),
                localTime.Offset.Minutes,
                localTime.Offset.Hours < 0 ? "earlier" : "later");
        }

        [Test]
        public void OriginalExample()
        {
            // see: Street Coder: 2 Practical theory: 2.3.3   Don’t framework hard, framework smart
            var now = DateTimeOffset.Now;
            var birthDate =
                new DateTimeOffset(1976, 12, 21, 02, 00, 00,
                    TimeSpan.FromHours(2));
            TimeSpan timePassed = now - birthDate;
            Console.WriteLine($"It’s been {timePassed.TotalSeconds} seconds since I was born!");
        }
    }
}