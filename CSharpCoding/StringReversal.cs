using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace CSharpCoding
{
    public class StringReversal
    {
        // Reversing a string - manually reversing character buffer
        // 1st allocation - original string
        // 2nd allocation - character array
        // 3rd allocation - the reversed string
        public static string ReverseUsingCharacterBuffer(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] inputAsArray = new char[input.Length];
            for (int start = 0, end = inputAsArray.Length - 1; start <= end; start++, end--)
            {
                inputAsArray[end] = input[start];
                inputAsArray[start] = input[end];
            }
            return new string(inputAsArray);
        }

        // Reversing a string using Array.Reverse
        // 1st allocation - original string
        // 2nd allocation - character array
        // 3rd allocation - the reversed string
        public static string ReverseUsingArrayClass(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] array = input.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }

        // Reverse using Linq
        // 1st allocation - original string
        // 2nd allocation - result from reverse
        // 3rd allocation - character array
        // 4th allocation - the reversed string
        public static string ReverseUsingLinq(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return new string(input.Reverse().ToArray());
        }

        // Reversing a string using StringBuilder
        // 1st allocation - original string
        // 2nd allocation - StringBuilder allocations are small, but are still n characters
        // 3rd allocation - the reversed string
        public static string ReverseUsingStringBuilder(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder builder = new StringBuilder(input.Length);
            for (int index = input.Length - 1; index >= 0; index--)
            {
                builder.Append(input[index]);
            }

            return builder.ToString();
        }

        // Reverse using a stack
        // 1st allocation - original string
        // 2nd allocation - the stack
        // 3rd allocation - the string builder
        // 4th allocation - the reversed string
        public static string ReverseUsingStack(string input)
        {
            Stack<char> resultStack = new Stack<char>();
            foreach (char c in input)
            {
                resultStack.Push(c);
            }

            StringBuilder sb = new StringBuilder();
            while (resultStack.Count > 0)
            {
                sb.Append(resultStack.Pop());
            }
            return sb.ToString();
        }

        // Reversing a string using XOR in character buffer
        // 1st allocation - original string
        // 2nd allocation - character buffer
        // 3rd allocation - the reversed string
        public static string ReverseUsingXOR(string text)
        {
            char[] charArray = text.ToCharArray();
            int length = text.Length - 1;
            for (int i = 0; i < length; i++, length--)
            {
                charArray[i] ^= charArray[length];
                charArray[length] ^= charArray[i];
                charArray[i] ^= charArray[length];
            }

            return new string(charArray);
        }

        // Reversing a character buffer in-place
        // 1st allocation - original buffer
        public static void ReverseInPlace(char[] input)
        {
            Array.Reverse(input);
        }
    }
}
