using NUnit.Framework;

namespace CodeKata.Kata.StringEnds
{
    [TestFixture]
    public class StringEndsTest
    {
        // see: https://www.codewars.com/kata/51f2d1cafc9c0f745c00037d/train/csharp
        
        private static object[] sampleTestCases = new object[]
        {
            new object[] {"samurai", "ai", true},
            new object[] {"sumo", "omo", false},
            new object[] {"ninja", "ja", true},
            new object[] {"sensei", "i", true},
            new object[] {"samurai", "ra", false},
            new object[] {"abc", "abcd", false},
            new object[] {"abc", "abc", true},
            new object[] {"abcabc", "bc", true},
            new object[] {"ails", "fails", false},
            new object[] {"fails", "ails", true},
            new object[] {"this", "fails", false},
            new object[] {"abc", "", true},
            new object[] {":-)", ":-(", false},
            new object[] {"!@#$%^&*() :-)", ":-)", true},
            new object[] {"abc\n", "abc", false},
        };

        private static object[] smallerTestCases = new object[]
        {
            new object[] {"ninja", "ja", true}
        };

        [Test, TestCaseSource("sampleTestCases")]
        public void SampleTest(string str, string ending, bool expected)
        {
            Assert.AreEqual(expected, StringEnds(str, ending));
        }

        [Test, TestCaseSource("smallerTestCases")]
        public void OneTest(string str, string ending, bool expected)
        {
            Assert.AreEqual(expected, StringEnds(str, ending));
        }

        public static bool StringEnds(string str, string ending)
        {
            if (str.Contains(ending) && str.Length == str.IndexOf(ending) + ending.Length)
                return true;
            
            return false;
        }
    }
}