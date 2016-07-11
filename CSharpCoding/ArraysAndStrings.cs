using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoding
{
    public class ArraysAndStrings
    {
        public static bool HasAllUniqueCharacters(string aString)
        {
            if(aString == null)
            {
                throw new ArgumentNullException(nameof(aString));
            }

            if(aString.Length == 0)
            {
                return true;
            }

            if(aString.Length > 128)
            {
                return false;
            }

            bool[] LettersSeen = new bool[128];
            foreach(var character in aString)
            {
                int index = (int)character;
                if(LettersSeen[index])
                {
                    return false;
                }
                else
                {
                    LettersSeen[index] = true;
                }
            }

            return true;

        }
    }
}
