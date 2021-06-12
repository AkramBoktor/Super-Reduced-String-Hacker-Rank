using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Reduced_String
{
    class Program
    {
        /*aaabccddd*/
        /*abd*/
        public static string superReducedString(string s)
        {
            int len = s.Length;

            while (len > 1)
            {
                if (s[len - 1] == s[len - 2])
                {
                    s = s.Remove(len - 1, 1);
                    s = s.Remove(len - 2, 1);
                    len = s.Length;
                }
                else
                {
                    len--;
                }
            }
            return s.Length == 0 ? "Empty String" : s;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            string s = Console.ReadLine();

            string result = Program.superReducedString(s);

            Console.WriteLine(result);


        }
    }
}