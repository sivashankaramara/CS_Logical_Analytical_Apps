using System;

namespace CharactersCountInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string to count a character");
            char ch = 'a';
            string str = Console.ReadLine();
            Int32 count = 0;
            char[] array = str.ToCharArray();
            for(Int32 i=0;i<str.Length;i++)
            {
                if(array[i]==ch)
                {
                    count += 1;
                }
            }
            Console.WriteLine("Total number of character in word:{0}",count);
            Console.ReadKey();
        }
    }
}
