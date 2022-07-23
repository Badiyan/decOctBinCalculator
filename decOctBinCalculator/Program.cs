using System;
using System.Linq;


namespace decOctBinCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restart:
            Console.WriteLine("Input number to convert, fromBase and toBase using spaces (Supported bases are 2, 8, 10 and 16): \n");
            //string number = "100";
            string inputDataRaw = Console.ReadLine();
            string[] inputDataSplitted = inputDataRaw.Split(' ');
            
            string[] allowedBases = { "2", "8", "10", "16" };
            if ((allowedBases.Contains(inputDataSplitted[1]) == false) | (allowedBases.Contains(inputDataSplitted[2]) == false))  {
                Console.WriteLine("\n Incorrect base value \n");
                goto Restart; 
            };
            string numberStr = inputDataSplitted[0];
            int fromBase = int.Parse(inputDataSplitted[1]);
            int toBase = int.Parse(inputDataSplitted[2]);
            string result = Convert.ToString(Convert.ToInt32(numberStr, fromBase), toBase);
            Console.WriteLine("\n The number {0} with base{1} converted to base{2} equal {3} \n ", 
                numberStr, fromBase, toBase, result);
            Console.Write("Press <Enter> to next... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            goto Restart;
        }
    }
}
