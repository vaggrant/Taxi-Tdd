using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd_Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("没有参数");
            }
            else
            {
                TaxiCaculator taxiCaculator = new TaxiCaculator(args[0]);
                Console.WriteLine(taxiCaculator.GetTaxiReceipt());
            }
            Console.ReadKey();            
        }
    }
}
