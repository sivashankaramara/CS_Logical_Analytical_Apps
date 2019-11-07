using System;

namespace StringReverseWithPredefinedFuns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string to reverse");
            string strToBeRevesred = Console.ReadLine();
            string strReversed = ReverseString(strToBeRevesred);
            Console.WriteLine(strReversed);
            Console.ReadKey();
        }

        /// <summary>
        /// Receives string and returns the string with its letters reversed.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            //Reverse: The method calls Array.Reverse to modify the order of the chars. Reverse cannot be used on a string directly.
            Array.Reverse(array);
            return new string(array);
        }
    }
}
