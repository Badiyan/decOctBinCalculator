using System;
using System.Linq;


namespace decOctBinCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Input number to convert, fromBase and toBase using spaces (Supported bases are 2, 8, 10 and 16): \n");
                //string number = "100";
                string inputDataRaw = Console.ReadLine();
                if (inputDataRaw == "")
                {
                    Console.WriteLine("\n Empty input \n");
                    Environment.Exit(0);
                }
                string[] inputDataSplitted = inputDataRaw.Split(' ');
                string[] allowedBases = { "2", "8", "10", "16" };
                if ((allowedBases.Contains(inputDataSplitted[1]) == false) | (allowedBases.Contains(inputDataSplitted[2]) == false) | (inputDataSplitted[1] == inputDataSplitted[2]))
                {
                    Console.WriteLine("\n Incorrect base value \n");
                    Environment.Exit(0);
                };
                string numberStr = inputDataSplitted[0];
                int fromBase = int.Parse(inputDataSplitted[1]);
                int toBase = int.Parse(inputDataSplitted[2]);
                try
                {
                    string tryResult = Convert.ToString(Convert.ToInt32(numberStr, fromBase), toBase);
                }
                catch (FormatException)
                {
                    Console.WriteLine("The format of '{0}' is invalid.", numberStr);
                    Environment.Exit(0);
                }
                string result = Convert.ToString(Convert.ToInt32(numberStr, fromBase), toBase);
                Console.WriteLine("\n The number {0} with base{1} converted to base{2} equal {3} \n ",
                    numberStr, fromBase, toBase, result);
                Console.Write("Press <Enter> to next... Any other key for exit ");
                while (Console.ReadKey().Key != ConsoleKey.Enter) 
                {
                    Environment.Exit(0);
                }

                
            }
        }
    }
}
