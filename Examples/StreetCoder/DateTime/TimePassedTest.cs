using System;
using NUnit.Framework;

namespace CodeKata.Examples.StreetCoder.DateTime
{
    [TestFixture]
    public class TimePassedTest
    {
        private DateTimeOffset _dateFrom;
        private TimeSpan _offset;
        private TimeOffset _time;

        [SetUp]
        public void SetUp()
        {
            var now = DateTimeOffset.Now;
            _offset = TimeSpan.FromHours(now.Offset.Hours);
        }

        [Test]
        public void ExampleForInspiration()
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
            
            _time = new TimeOffset(_dateFrom);
            
            Assert.AreEqual(0, _time.TimePassed.Hours);
        }
        
        [Test]
        public void MyBirthdayTest()
        {
            _dateFrom = new DateTimeOffset(1991, 12, 23, 13, 00, 00, _offset);
            _time = new TimeOffset(_dateFrom);
            
            Assert.True(_time.TimePassed.Days / 365 >= 29, "Should be at least 29 years");
            
            Console.WriteLine(_time.ToString());
        }
    }
}