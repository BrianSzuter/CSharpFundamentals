using NUnit.Framework;
using CSharpCoding;

namespace CSharpCodingTest
{
    [TestFixture]
    public class IntegerToEnglishConverterTest
    {
        private void ToEnglishString_CommonHelper(int testVal, string expected)
        {
            var result = IntegerToEnglishConverter.ToEnglishString(testVal);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ToEnglishString_Zero_ReturnsZero()
        {
            ToEnglishString_CommonHelper(0, "Zero");
        }

        [Test]
        public void ToEnglishString_MaxInt_ReturnsAsString()
        {
            ToEnglishString_CommonHelper(int.MaxValue, "Two Billion One Hundred Forty Seven Million Four Hundred Eighty Three Thousand Six Hundred Forty Seven");
        }

        [Test]
        public void ToEnglishString_MinInt_ReturnsAsString()
        {
            ToEnglishString_CommonHelper(int.MinValue, "Negative Two Billion One Hundred Forty Seven Million Four Hundred Eighty Three Thousand Six Hundred Forty Eight");
        }

        [TestCase(1, "One")]
        [TestCase(2, "Two")]
        [TestCase(3, "Three")]
        [TestCase(4, "Four")]
        [TestCase(5, "Five")]
        [TestCase(6, "Six")]
        [TestCase(7, "Seven")]
        [TestCase(8, "Eight")]
        [TestCase(9, "Nine")]
        public void ToEnglishString_SingleDigit_ReturnsAsString(int testVal, string expected)
        {
            ToEnglishString_CommonHelper(testVal, expected);
        }

        [TestCase(10, "Ten")]
        [TestCase(15, "Fifteen")]
        [TestCase(19, "Nineteen")]
        public void ToEnglishString_Teen_ReturnsAsString(int testVal, string expected)
        {
            ToEnglishString_CommonHelper(testVal, expected);
        }

        [TestCase(20, "Twenty")]
        [TestCase(21, "Twenty One")]
        [TestCase(32, "Thirty Two")]
        [TestCase(43, "Forty Three")]
        [TestCase(54, "Fifty Four")]
        [TestCase(65, "Sixty Five")]
        [TestCase(76, "Seventy Six")]
        [TestCase(87, "Eighty Seven")]
        [TestCase(98, "Ninety Eight")]
        [TestCase(99, "Ninety Nine")]
        public void ToEnglishString_TwentyToHundred_ReturnsAsString(int testVal, string expected)
        {
            ToEnglishString_CommonHelper(testVal, expected);
        }

        [TestCase(100, "One Hundred")]
        [TestCase(101, "One Hundred One")]
        [TestCase(110, "One Hundred Ten")]
        [TestCase(115, "One Hundred Fifteen")]
        [TestCase(120, "One Hundred Twenty")]
        [TestCase(121, "One Hundred Twenty One")]        
        [TestCase(232, "Two Hundred Thirty Two")]
        [TestCase(343, "Three Hundred Forty Three")]
        [TestCase(454, "Four Hundred Fifty Four")]
        [TestCase(532, "Five Hundred Thirty Two")]
        [TestCase(565, "Five Hundred Sixty Five")]
        [TestCase(676, "Six Hundred Seventy Six")]
        [TestCase(787, "Seven Hundred Eighty Seven")]
        [TestCase(898, "Eight Hundred Ninety Eight")]        
        [TestCase(999, "Nine Hundred Ninety Nine")]
        public void ToEnglishString_Hundreds_ReturnsAsString(int testVal, string expected)
        {
            ToEnglishString_CommonHelper(testVal, expected);
        }

        [TestCase(1000, "One Thousand")]
        [TestCase(1100, "One Thousand One Hundred")]
        [TestCase(2101, "Two Thousand One Hundred One")]
        [TestCase(3110, "Three Thousand One Hundred Ten")]
        [TestCase(4115, "Four Thousand One Hundred Fifteen")]
        [TestCase(5121, "Five Thousand One Hundred Twenty One")]
        [TestCase(8532, "Eight Thousand Five Hundred Thirty Two")]
        [TestCase(9999, "Nine Thousand Nine Hundred Ninety Nine")]
        public void ToEnglishString_Thousands_ReturnsAsString(int testVal, string expected)
        {
            ToEnglishString_CommonHelper(testVal, expected);
        }

        [TestCase(10000, "Ten Thousand")]
        [TestCase(10001, "Ten Thousand One")]
        [TestCase(10012, "Ten Thousand Twelve")]
        [TestCase(11000, "Eleven Thousand")]
        [TestCase(21100, "Twenty One Thousand One Hundred")]
        [TestCase(32101, "Thirty Two Thousand One Hundred One")]
        [TestCase(43110, "Forty Three Thousand One Hundred Ten")]
        [TestCase(54115, "Fifty Four Thousand One Hundred Fifteen")]
        [TestCase(65121, "Sixty Five Thousand One Hundred Twenty One")]
        [TestCase(78532, "Seventy Eight Thousand Five Hundred Thirty Two")]
        [TestCase(89999, "Eighty Nine Thousand Nine Hundred Ninety Nine")]
        [TestCase(99999, "Ninety Nine Thousand Nine Hundred Ninety Nine")]
        public void ToEnglishString_TensOfThousands_ReturnsAsString(int testVal, string expected)
        {
            ToEnglishString_CommonHelper(testVal, expected);
        }

        [TestCase(100000, "One Hundred Thousand")]
        [TestCase(100001, "One Hundred Thousand One")]
        [TestCase(100012, "One Hundred Thousand Twelve")]
        [TestCase(110000, "One Hundred Ten Thousand")]
        [TestCase(121100, "One Hundred Twenty One Thousand One Hundred")]
        [TestCase(232101, "Two Hundred Thirty Two Thousand One Hundred One")]
        [TestCase(343110, "Three Hundred Forty Three Thousand One Hundred Ten")]
        [TestCase(454115, "Four Hundred Fifty Four Thousand One Hundred Fifteen")]
        [TestCase(565121, "Five Hundred Sixty Five Thousand One Hundred Twenty One")]
        [TestCase(678532, "Six Hundred Seventy Eight Thousand Five Hundred Thirty Two")]
        [TestCase(789999, "Seven Hundred Eighty Nine Thousand Nine Hundred Ninety Nine")]
        [TestCase(899999, "Eight Hundred Ninety Nine Thousand Nine Hundred Ninety Nine")]
        [TestCase(999999, "Nine Hundred Ninety Nine Thousand Nine Hundred Ninety Nine")]
        public void ToEnglishString_HundredsOfThousands_ReturnsAsString(int testVal, string expected)
        {
            ToEnglishString_CommonHelper(testVal, expected);
        }

        [TestCase(1000000, "One Million")]
        [TestCase(1000009, "One Million Nine")]
        [TestCase(1000012, "One Million Twelve")]
        [TestCase(1110000, "One Million One Hundred Ten Thousand")]
        [TestCase(9121100, "Nine Million One Hundred Twenty One Thousand One Hundred")]
        [TestCase(8232101, "Eight Million Two Hundred Thirty Two Thousand One Hundred One")]
        [TestCase(7343110, "Seven Million Three Hundred Forty Three Thousand One Hundred Ten")]
        [TestCase(6454115, "Six Million Four Hundred Fifty Four Thousand One Hundred Fifteen")]
        [TestCase(5565121, "Five Million Five Hundred Sixty Five Thousand One Hundred Twenty One")]
        [TestCase(4678532, "Four Million Six Hundred Seventy Eight Thousand Five Hundred Thirty Two")]
        [TestCase(3789999, "Three Million Seven Hundred Eighty Nine Thousand Nine Hundred Ninety Nine")]
        [TestCase(2899999, "Two Million Eight Hundred Ninety Nine Thousand Nine Hundred Ninety Nine")]
        [TestCase(1999999, "One Million Nine Hundred Ninety Nine Thousand Nine Hundred Ninety Nine")]
        [TestCase(9999999, "Nine Million Nine Hundred Ninety Nine Thousand Nine Hundred Ninety Nine")]
        [TestCase(999999999, "Nine Hundred Ninety Nine Million Nine Hundred Ninety Nine Thousand Nine Hundred Ninety Nine")]
        public void ToEnglishString_Millions_ReturnsAsString(int testVal, string expected)
        {
            ToEnglishString_CommonHelper(testVal, expected);
        }

        [TestCase(1000000000, "One Billion")]
        [TestCase(1000000013, "One Billion Thirteen")]
        [TestCase(1000900000, "One Billion Nine Hundred Thousand")]
        public void ToEnglishString_Billions_ReturnsAsString(int testVal, string expected)
        {
            ToEnglishString_CommonHelper(testVal, expected);
        }

        [TestCase(-1, "Negative One")]
        [TestCase(-11, "Negative Eleven")]
        public void ToEnglishString_Negatives_ReturnsAsNegativeString(int testVal, string expected)
        {
            ToEnglishString_CommonHelper(testVal, expected);
        }

    }
}
