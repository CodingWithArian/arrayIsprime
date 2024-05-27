using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayIsprime
{
    internal class Program
    {
        static bool IsPrime(int n)
        {
            for (int i = 2; i <= n / 2; i++)
            
                if (n % i == 0) return false;
                return true;
            
        }
        static void Main(string[] args)
        {
            int count = 0;string output="",primeNums = "";
            int[,] numbers = new int[2,2];
            Console.WriteLine("Enter Array's elements");
            for(int i = 0; i < numbers.GetLength(0); i++)
            {
                Console.WriteLine("row{0}", i);
                for (int j = 0; j < numbers.GetLength(1); j++)
                    numbers[i, j] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("Your Array iss");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {

                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    output += numbers[i, j] + "\t";
                    if (IsPrime(numbers[i,j]))
                    {
                        primeNums += numbers[i,j] + "\t";
                    }
                }

                output += "\n";
            }
            Console.WriteLine(output);
            Console.WriteLine("your prime numbers are {0}", primeNums);

            Console.ReadKey();

        }
    }
}
