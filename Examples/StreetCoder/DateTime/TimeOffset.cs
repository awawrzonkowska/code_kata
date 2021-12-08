using System;
using System.Text;

namespace CodeKata.Examples.StreetCoder.DateTime
{
    public class TimeOffset
    {
        public TimeSpan TimePassed { get; }

        public override string ToString()
        {
            var result = new StringBuilder()
                    .Append($"It’s been {TimePassed.TotalSeconds} seconds since I was born!\n")
                    .Append($"It’s been {TimePassed.TotalDays} days since I was born!\n")
                    .Append($"It’s been {decimal.Floor((decimal) (TimePassed.TotalDays / 365))} years since I was born!\n");
            return result.ToString();
        }

        public TimeOffset(DateTimeOffset @from)
        {
            TimePassed = Passed(@from);
        }

        private TimeSpan Passed(DateTimeOffset @from)
        {
            var now = DateTimeOffset.Now;

            var timePassed = now - @from;

            return timePassed;
        }
    }
}