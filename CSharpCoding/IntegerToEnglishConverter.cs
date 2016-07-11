using System;

namespace CSharpCoding
{
    public class IntegerToEnglishConverter
    {
        public static string ToEnglishString(int MyInt)
        {
            if (MyInt == 0)
            {
                return "Zero";
            }

            bool isNegative = (MyInt < 0);
            uint MyUInt = isNegative ? (uint)(-1 * MyInt) : (uint)MyInt;

            uint PeriodValuesHundreds = GetHundredsPeriod(MyUInt);
            uint PeriodValuesThousands = GetThousandsPeriod(MyUInt);
            uint PeriodValuesMillions = GetMillionsPeriod(MyUInt);
            uint PeriodValuesBillions = GetBillionsPeriod(MyUInt);

            string HundredsPeriodString = ConvertPeriodToString(PeriodValuesHundreds);

            string ThousandsPeriodString = ConvertPeriodToString(PeriodValuesThousands);
            if(ThousandsPeriodString.Length > 0)
            {
                ThousandsPeriodString += " Thousand";
            }

            string MillionsPeriodString = ConvertPeriodToString(PeriodValuesMillions);
            if (MillionsPeriodString.Length > 0)
            {
                MillionsPeriodString += " Million";
            }

            string BillionsPeriodString = ConvertPeriodToString(PeriodValuesBillions);
            if (BillionsPeriodString.Length > 0)
            {
                BillionsPeriodString += " Billion";
            }

            string Negative = "";
            if(isNegative)
            {
                Negative = "Negative";
            }

            return ((((Negative + " " + BillionsPeriodString).Trim() + " " + MillionsPeriodString).Trim() + " " + ThousandsPeriodString).Trim() + " " + HundredsPeriodString).Trim();
        }

        private static string ConvertPeriodToString(uint MyInt)
        {
            uint DroppedHundreds = GetTensAndOnesDigits(MyInt);

            string TwoLeastSignificantDigits;
            if (DroppedHundreds > 9 && DroppedHundreds < 20)
            {
                TwoLeastSignificantDigits = GetTeensAsString(DroppedHundreds);
            }
            else
            {
                uint TensDigit = GetTensDigit(DroppedHundreds);
                uint OneDigit = GetOnesDigit(DroppedHundreds);
                string Tens = GetTensAsString(TensDigit);
                string Ones = GetOnesAsString(OneDigit);

                TwoLeastSignificantDigits = (Tens + " " + Ones).Trim();
            }

            uint HundredsDigit = GetHundredsDigit(MyInt);
            string Hundreds = GetHundredsAsString(HundredsDigit);

            return (Hundreds + " " + TwoLeastSignificantDigits).Trim();
        }

        private static uint GetBillionsPeriod(uint myInt)
        {
            return (myInt / 1000000000);
        }

        private static uint GetMillionsPeriod(uint myInt)
        {
            return (myInt % 1000000000) / 1000000;
        }

        private static uint GetThousandsPeriod(uint myInt)
        {
            return (myInt % 1000000) / 1000;
        }

        private static uint GetHundredsPeriod(uint myInt)
        {
            return (myInt % 1000);
        }

        private static uint GetHundredsDigit(uint myInt)
        {
            return (myInt % 1000) / 100;
        }

        private static uint GetTensAndOnesDigits(uint myInt)
        {
            return (myInt % 100);
        }

        private static uint GetTensDigit(uint myInt)
        {
            return (myInt % 100) / 10;
        }

        private static uint GetOnesDigit(uint myInt)
        {
            return (myInt % 10);
        }        

        private static string GetHundredsAsString(uint hundredsDigit)
        {
            string hundreds = GetOnesAsString(hundredsDigit);
            if (hundreds.Length > 0)
                hundreds += " " + "Hundred";

            return hundreds;
        }

        private static string GetTensAsString(uint tensDigit)
        {
            switch (tensDigit)
            {
                case 0: return "";
                case 1: return "Ten";
                case 2: return "Twenty";
                case 3: return "Thirty";
                case 4: return "Forty";
                case 5: return "Fifty";
                case 6: return "Sixty";
                case 7: return "Seventy";
                case 8: return "Eighty";
                case 9: return "Ninety";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        private static string GetOnesAsString(uint singleDigit)
        {
            switch (singleDigit)
            {
                case 0: return "";
                case 1: return "One";
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        private static string GetTeensAsString(uint teenValue)
        { 
            switch(teenValue)
            { 
                case 10: return "Ten";
                case 11: return "Eleven";
                case 12: return "Twelve";
                case 13: return "Thirteen";
                case 14: return "Fourteen";
                case 15: return "Fifteen";
                case 16: return "Sixteen";
                case 17: return "Seventeen";
                case 18: return "Eighteen";
                case 19: return "Nineteen";
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}
