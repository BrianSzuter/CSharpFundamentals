using System;
using CSharpCoding;
using NUnit.Framework;

namespace CSharpCodingTest
{
    [TestFixture]
    public class ArraysAndStringsTest
    {
        [Test]
        public void HasAllUniqueCharacters_EmptyString_ReturnsTrue()
        {
            var result = ArraysAndStrings.HasAllUniqueCharacters("");
            Assert.IsTrue(result);
        }

        [Test]
        public void HasAllUniqueCharacters_Null_RaisesException()
        {
            var ex = Assert.Catch<Exception>(() => ArraysAndStrings.HasAllUniqueCharacters(null));
            StringAssert.Contains("Value cannot be null", ex.Message);
        }

        [TestCase("A")]
        [TestCase("a")]
        [TestCase("a1234567890")]
        [TestCase("BOb")]
        public void HasAllUniqueCharacters_TheseStrings_ReturnsTrue(string TestVal)
        {
            var result = ArraysAndStrings.HasAllUniqueCharacters(TestVal);
            Assert.IsTrue(result);
        }

        [TestCase("AA")]
        [TestCase("\0x0\0x0")]
        [TestCase("\0x7F\0x7F")]
        [TestCase("BOB")]
        public void HasAllUniqueCharacters_TheseStrings_ReturnsFalse(string TestVal)
        {
            var result = ArraysAndStrings.HasAllUniqueCharacters(TestVal);
            Assert.IsFalse(result);
        }
    }
}
