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
            DateTimeOffset localTime = DateTimeOffset.Now;
            
            Console.WriteLine("The local time zone is {0} hours and {1} minutes {2} than UTC.",
                Math.Abs(localTime.Offset.Hours),
                localTime.Offset.Minutes,
                localTime.Offset.Hours < 0 ? "earlier" : "later");
        }

        [Test]
        public void OriginalExample()
        {
            var now = DateTimeOffset.Now;
            var birthDate =
                new DateTimeOffset(1976, 12, 21, 02, 00, 00,
                    TimeSpan.FromHours(2));
            TimeSpan timePassed = now - birthDate;
            Console.WriteLine($"It’s been {timePassed.TotalSeconds} seconds since I was born!");
        }
    }
}