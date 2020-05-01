using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiTdd
{
    internal class FirstReceiptLevelCaculator : ReceiptLevelCaculator
    {
        private int baseCharge = 6;
        public override double GetLevelReceipt(int distance)
        {
            return baseCharge;
        }
    }
}
