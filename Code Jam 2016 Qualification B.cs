using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Jam_Qualification_B
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader file = new System.IO.StreamReader("c:\\users\\Anubhav\\Downloads\\B-large.in");
            System.IO.StreamWriter fileout = new System.IO.StreamWriter("c:\\users\\Anubhav\\Downloads\\B-large.out");

            int t = int.Parse(file.ReadLine());

            for (int i = 1; i <= t; i++)
            {
                string s = file.ReadLine();

                // Removes trivial plus signs
                s = s.TrimEnd('+');

                if (s != "")
                {
                    int inversions = 0;
                    char prevch = s[0];

                    for (int count = 1; count < s.Length; count++)
                    {
                        if (s[count] != prevch)
                        {
                            inversions++;
                        }
                        prevch = s[count];
                    }
                    fileout.WriteLine("Case #" + i + ": " + (inversions + 1));
                    Console.WriteLine("Case #" + i + ": " + (inversions + 1));
                }

                else
                {
                    fileout.WriteLine("Case #" + i + ": 0");
                    Console.WriteLine("Case #" + i + ": 0");
                }
            }

            file.Close();
            fileout.Close();
            Console.ReadLine();
        }
    }
}
