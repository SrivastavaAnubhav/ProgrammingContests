using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader("c:\\users\\Anubhav\\Downloads\\A-large.in");
            System.IO.StreamWriter fileout = new System.IO.StreamWriter("c:\\users\\Anubhav\\Downloads\\A-large.out");

            int t = int.Parse(file.ReadLine());
            HashSet<char> nums = new HashSet<char>();

            for (int i = 1; i <= t; i++)
            {
                int N = int.Parse(file.ReadLine());
                if (N == 0)
                {
                    fileout.WriteLine("Case #" + i + ": INSOMNIA");
                    Console.WriteLine("Case #" + i + ": INSOMNIA");
                }
                else
                {
                    int coefficient = 0;
                    while (nums.Count != 10)
                    {
                        coefficient++;
                        string numstring = (N * coefficient).ToString();
                        foreach (char ch in numstring)
                        {
                            nums.Add(ch);
                        }
                    }
                    fileout.WriteLine("Case #" + i + ": " + (N * coefficient));
                    Console.WriteLine("Case #" + i + ": " + (N*coefficient));
                    nums.Clear();
                }
            }

            file.Close();

            // Suspend the screen.
            fileout.Close();
            Console.ReadLine();
        }
    }
}
