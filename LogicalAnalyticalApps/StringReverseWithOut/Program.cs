using System;
using System.Diagnostics;

namespace StringReverseWithOut
{
    class Program
    {
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

        public static string ReverseStringDirect(string s)
        {
            char[] array = new char[s.Length];
            Int32 forward = 0;
            for(Int32 i=s.Length-1;i>=0;i--)
            {
                array[forward++] = s[i];                
            }
            return new string(array);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string to reverse");
            string strToBeRevesred = Console.ReadLine();
            int sum = 0;
            const int _max = 1000000;
            Console.WriteLine(ReverseString(strToBeRevesred));
            Console.WriteLine(ReverseStringDirect(strToBeRevesred));
            // Version 1: reverse with ToCharArray.
            Stopwatch s1 = Stopwatch.StartNew();
            for (int i = 0; i < _max; i++)
            {
                sum += ReverseString("programmingisfun").Length;
            }
            s1.Stop();

            // Version 2: reverse with iteration.
            Stopwatch s2 = Stopwatch.StartNew();
            for (int i = 0; i < _max; i++)
            {
                sum += ReverseStringDirect("programmingisfun").Length;
            }
            s2.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds);
            Console.WriteLine(s2.Elapsed.TotalMilliseconds);
            Console.ReadKey();
        }
    }
}
