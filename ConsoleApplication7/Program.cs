using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "people";
            string s2 = "abcdefg";
            string s3 = "dictionary";
            bool iso = true;

            s2.ToLower();
            
            for (int i = 0; i < s2.Length; i++)
            {
                char letter = s2[i];
                for (int x = 0; x < s2.Length; x++)
                {
                    if (x == i) { }

                    else
                    {
                        if (letter == s2[x])
                        {
                            iso = false;                            
                        }
                    }
                }
            }
            if (iso)
            {
                Console.WriteLine(s2 + " is an Isogram");
            }
            else
                Console.WriteLine(s2 + "is not an Isogram");
        }
    }
    
}
