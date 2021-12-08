using System;
using NUnit.Framework;

namespace CodeKata.Examples.StreetCoder.DateTime
{
    public static class TimeOffset
    {
        public static TimeSpan TimePassed(DateTimeOffset @from)
        {
            var now = DateTimeOffset.Now;

            var timePassed = now - @from;

            return timePassed;
        }
        
    }

    [TestFixture]
    public class TimePassedTest
    {
        private DateTimeOffset _dateFrom;
        private TimeSpan _offset;

        [SetUp]
        public void SetUp()
        {
            var now = DateTimeOffset.Now;
            _offset = TimeSpan.FromHours(now.Offset.Hours);
        }

        [Test]
        public void RefactoredExample()
        {
            var now = DateTimeOffset.Now;
            var birthDate =
                new DateTimeOffset(
                    1976, 12, 21, 02, 00, 00, 
                    TimeSpan.FromHours(now.Offset.Hours));
            
            TimeSpan timePassed = now - birthDate;
            
            Console.WriteLine($"It’s been {timePassed.TotalSeconds} seconds since I was born!");
            Console.WriteLine($"It’s been {timePassed.TotalDays} days since I was born!");
            Console.WriteLine($"It’s been {decimal.Floor((decimal) (timePassed.TotalDays / 365))} years since I was born!");
        }
        
        [Test]
        public void NowTest()
        {
            _dateFrom = DateTimeOffset.Now;
            
            var timePassed = TimeOffset.TimePassed(_dateFrom);

            Assert.AreEqual(0, timePassed.Hours);
        }
        
        [Test]
        public void MyBirthdayTest()
        {
            _dateFrom = new DateTimeOffset(1991, 12, 23, 00, 00, 00, _offset);
            
            var timePassed = TimeOffset.TimePassed(_dateFrom);
            
            Assert.AreEqual(29, timePassed.Days / 365);
            
            Console.WriteLine(timePassed);
        }
    }
}