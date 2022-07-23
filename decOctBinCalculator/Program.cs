using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decOctBinCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number to convert:");
            //string number = "100";
            string inputNumber = Console.ReadLine();
            Console.WriteLine(inputNumber);
            //int fromBase = 16;
            //int toBase = 10;

            //string result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);

            // result == "256"
            // Supported bases are 2, 8, 10 and 16
        }
    }
}
