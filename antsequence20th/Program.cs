using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antsequence20th
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "1", ss;
            char ch;
            int count = 0;
            for (int i = 0; i < 19; i++)
            {
                Console.WriteLine(i+1 + "번째 숫자: " + s);
                count = 0;
                ch = s[0];
                ss = "";
                Console.WriteLine(s);
                for (int j = 0; j < s.Length; j++)
                {
                    if (ch == s[j])
                    {
                        count++;
                    }
                    else
                    {
                        ss = ss + ch + count;
                        count = 0;
                        ch = s[j];
                        count++;
                    }
                    if (j + 1 == s.Length)
                    {
                        ss = ss + ch + count;
                    }

                }
                s = ss;
            }

            Console.WriteLine("\n20번째 숫자: " + s);
        }
    }
}
