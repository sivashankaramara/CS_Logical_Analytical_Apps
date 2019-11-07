using System;

namespace AddSpacesBetweenCharactersInString
{
    class Program
    {
        public static string AddSpace(string strInput)
        {
            char[] array = new char[strInput.Length * 2];
            Int32 forward = 0;
            for (Int32 i = 0; i < strInput.Length; i++)
            {
                array[forward++] = strInput[i];
                array[forward++] = ' ';
            }
            return new string(array);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Provide input string");
            string strInput = Console.ReadLine();
            Console.WriteLine(AddSpace(strInput));            
            Console.ReadKey();
        }
    }
}
