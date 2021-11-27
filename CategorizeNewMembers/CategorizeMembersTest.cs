using NUnit.Framework;

namespace CodeKata.CategorizeNewMembers
{
    // https://www.codewars.com/kata/5502c9e7b3216ec63c0001aa/solutions/csharp/

    [TestFixture]
    public class CategorizeMembersTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new[] { "Open", "Senior", "Open", "Senior" }, CategorizeMembers.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }));
            Assert.AreEqual(new[] { "Open", "Open", "Open", "Open" }, CategorizeMembers.OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }));
            Assert.AreEqual(new[] { "Senior", "Open", "Open", "Open" }, CategorizeMembers.OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }));
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(
                new[] { 
                    "Open", "Senior", "Open", "Senior" 
                }, 
                CategorizeMembers.OpenOrSenior
                (new[] { 
                    new[] { 45, 12 }, 
                    new[] { 55, 21 }, 
                    new[] { 19, 2 }, 
                    new[] { 104, 20 } 
                }));
        }
    }
}
