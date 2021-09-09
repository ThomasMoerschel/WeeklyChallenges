using System;

namespace Week_1
{
    class Week1CSQ
    {
        public static string SomethingIsBetterThanNothing(string input)
        {
            return ("something " + input);
        }
        static void Main(string[] args)
        {

            bool repeat = true;
            while (repeat){
            Console.Clear();
            Console.WriteLine("Something is better than nothing...");
            Console.WriteLine("Please write a string and it will be placed after 'something'");
            string input = Console.ReadLine();
            Console.WriteLine(SomethingIsBetterThanNothing(input));
            Console.WriteLine("Retry? (Y/N)");
            string input2 = Console.ReadLine();
            switch (input2)
            {
                case "Y":
                case "y":
                    repeat = true;
                    break;
                case "N":
                case "n":
                    repeat = false;
                    break;
                default:
                    break;
            }
            }      
        }
    }
}
