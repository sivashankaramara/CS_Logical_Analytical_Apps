using System;
using System.Globalization;

namespace Sring_Comparision_3Ways
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "sister";
            string str2 = "Sister";
            string relation = string.Empty;
            Int32 result;
            // Cultural (linguistic) comparision.
            result = string.Compare(str1, str2, new CultureInfo("en-US"), CompareOptions.None);
            if (result > 0)
                relation = "comes after";
            else if (result == 0)
                relation = "is the same as";
            else
                relation = "comes before";
            Console.WriteLine("'{0}' {1} '{2}'.",str1,relation,str2);
            // Cultural (lingustic) case-insensitive comaparision
            result = string.Compare(str1, str2, new CultureInfo("en-US"), CompareOptions.IgnoreCase);
            if (result > 0)
                relation = "comes after";
            else if (result == 0)
                relation = "is the same as";
            else
                relation = "comes before";
            Console.WriteLine("'{0}' {1} '{2}'",str1, relation, str2);

            // Culture-insensitive ordinal comparison.
            result = string.CompareOrdinal(str1, str2);
            if (result > 0)
                relation = "comes after";
            else if (result == 0)
                relation = "is the same as";
            else
                relation = "comes before";

            Console.WriteLine("'{0}' {1} '{2}'.",
                              str1, relation, str2);
            Console.ReadKey();
        }
    }
}
