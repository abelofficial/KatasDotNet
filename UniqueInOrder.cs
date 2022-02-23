/** Kata question
Implement the function unique_in_order which takes as argument 
a sequence and returns a list of items without any elements with
the same value next to each other and preserving the original order of elements. 
*/

namespace Katas
{
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;

    public static class Kata
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            //your code here...
            return iterable.Aggregate(new List<T>(), (total, current) => total);
        }
    }

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void EmptyTest()
        {
            Assert.AreEqual("", Kata.UniqueInOrder(""));
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABCDAB", Kata.UniqueInOrder("AAAABBBCCDAABBB"));
        }
    }
}
