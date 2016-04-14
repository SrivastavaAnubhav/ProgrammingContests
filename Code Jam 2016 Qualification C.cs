using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Jam_Qualification_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 16;
            int J = 50;
			
			// Note: this did not give the correct output
			
            System.IO.StreamWriter fileout = new System.IO.StreamWriter("c:\\users\\Anubhav\\Downloads\\C-small.out");

            fileout.WriteLine("Case #1:");

            long start = Convert.ToInt64(Math.Pow(2, N-1)) + 1;
            long end = Convert.ToInt64(Math.Pow(2, N));
            for (long i = start; i < end; i += 2)
            {
                if (J != 0)
                {
                    string x = Convert.ToString(i, 2);
                    long[] divisors = new long[9];
                    for (int j = 2; j < 11; j++)
                    {
                        long result = primeInBase(x, j);

                        if (result != 0) divisors[j - 2] = result;
                        else j = 11;
                    }
                    if (divisors[8] != 0)
                    {
                        fileout.Write(x);
                        foreach (long num in divisors)
                        {
                            fileout.Write(" " + num);
                        }
                        fileout.Write("\n");
                        Console.WriteLine(J);
                        J--;
                    }
                }
                else break;
            }
            fileout.Close();
        }

        public static long isPrime(long number)
        {
            long boundary = Convert.ToInt64(Math.Floor(Math.Sqrt(number)));

            for (long i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return i;
            }

            return 0;
        }

        public static long primeInBase(string bin, int wantedBase)
        {
            long sum = 0;
            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[i] != '0')
                {
                    sum += Convert.ToInt64(Math.Pow(wantedBase, i));
                }
            }

            return isPrime(sum);
        }
    }
}
