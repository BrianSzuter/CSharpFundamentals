using CSharpCoding;
using NUnit.Framework;

namespace CSharpCodingTest
{
    [TestFixture]
    public class StringReversalTests
    {
        [TestCase("", "")]
        [TestCase("a", "a")]
        [TestCase("abcdef", "fedcba")]
        [TestCase("abcdef", "fedcba")]
        public void StringReversalTest(string input, string expected)
        {
            string resultCB = StringReversal.ReverseUsingCharacterBuffer(input);
            Assert.AreEqual(resultCB, expected);

            string resultArray = StringReversal.ReverseUsingArrayClass(input);
            Assert.AreEqual(resultArray, expected);

            string resultLinq = StringReversal.ReverseUsingLinq(input);
            Assert.AreEqual(resultLinq, expected);

            string resultSB = StringReversal.ReverseUsingStringBuilder(input);
            Assert.AreEqual(resultSB, expected);

            string resultStack = StringReversal.ReverseUsingStack(input);
            Assert.AreEqual(resultStack, expected);

            string resultXOR = StringReversal.ReverseUsingXOR(input);
            Assert.AreEqual(resultXOR, expected);
        }

        [TestCase(new char[0]{ }, new char[0] { })]
        [TestCase(new char[1]{'a'}, new char[1]{'a'})]
        [TestCase(new char[4]{'a', 'b', 'c', 'd'}, new char[4] {'d', 'c', 'b', 'a'})]
        public void ReverseInPlace_Test(char[] input, char[] expected)
        {

            StringReversal.ReverseInPlace(input);
            Assert.AreEqual(input, expected);
        }
    }
}
