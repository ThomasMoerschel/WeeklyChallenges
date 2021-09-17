using System;
using System.Collections.Generic;

namespace Week_2
{
    class Program
    {
        public static void Factorize (int num)
        {
            var primeFactors = new List<int>();

            for (int div = 2; div <= num; div++)
            {
                while (num % div == 0)
                {
                    primeFactors.Add(div);
                    num = num / div;
                }
            }
            Console.WriteLine(string.Join(", ", primeFactors));
            

        }
        static void Main(string[] args)
        {
            Boolean repeat = true;
            while(repeat)
            {
            Console.WriteLine("Factorization");
            Console.WriteLine("Please Input a number!");
            string num = Console.ReadLine();
            Factorize(Int32.Parse(num));

            Console.WriteLine("Test another Number? [Y/N]" );
            string response = Console.ReadLine();
            
            switch (response)
            {
                case "Y" or "y":
                    break;
                case "N" or "n":
                    repeat = false;
                    break;
                default:
                    repeat = false;
                    break;
            }
            }

        }
    }
}
