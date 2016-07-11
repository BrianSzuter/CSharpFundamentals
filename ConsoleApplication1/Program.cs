using System;
using System.Diagnostics;
using CSharpCoding;

namespace ConsoleApplication1
{
    class Program
    {
        private static Stopwatch stopwatch;
        private static int repeatCount;
        private static string testString;

        static void Main(string[] args)
        {
            MeasuringStringReversals();

            // Wait for input
            Console.WriteLine("\nPress any key...");
            var x = Console.Read();
        }

        private delegate string aReverseFunction(string input);

        private static void MeasureReversalFunction(aReverseFunction f, string name)
        {
            stopwatch.Reset();
            stopwatch.Start();
            {
                for (int i = 0; i < repeatCount; i++)
                {
                    f(testString);
                }
            }
            stopwatch.Stop();
            Console.WriteLine(name + ": " + stopwatch.ElapsedMilliseconds + "ms");
        }

        private static void MeasuringStringReversals()
        {
            testString = string.Join(";", new string[] {
                new string('a', 10000000),
                new string('b', 10000001),
                new string('c', 10000002),
                new string('d', 10000003),
            });
            Console.WriteLine(nameof(testString) + " Size is:" + testString.Length / 1024 / 1024 + " MB");

            repeatCount = 1;
            stopwatch = new Stopwatch();            

            stopwatch.Reset();
            stopwatch.Start();
            {
                char[] temp = testString.ToCharArray();
                for (int i = 0; i < repeatCount; i++)
                {
                    StringReversal.ReverseInPlace(temp);
                }
            }
            stopwatch.Stop();
            Console.WriteLine("ReverseInPlace: " + stopwatch.ElapsedMilliseconds + "ms");

            MeasureReversalFunction(StringReversal.ReverseUsingCharacterBuffer, nameof(StringReversal.ReverseUsingCharacterBuffer));
            MeasureReversalFunction(StringReversal.ReverseUsingArrayClass, nameof(StringReversal.ReverseUsingArrayClass));
            MeasureReversalFunction(StringReversal.ReverseUsingXOR, nameof(StringReversal.ReverseUsingXOR));
            MeasureReversalFunction(StringReversal.ReverseUsingStringBuilder, nameof(StringReversal.ReverseUsingStringBuilder));
            MeasureReversalFunction(StringReversal.ReverseUsingStack, nameof(StringReversal.ReverseUsingStack));
            MeasureReversalFunction(StringReversal.ReverseUsingLinq, nameof(StringReversal.ReverseUsingLinq));
        }
    }
}
