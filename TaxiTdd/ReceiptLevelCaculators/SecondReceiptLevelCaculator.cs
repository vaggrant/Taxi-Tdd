using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiTdd
{
    internal class SecondReceiptLevelCaculator : ReceiptLevelCaculator
    {
        private double stepCharge = 0.8;
        public override double GetLevelReceipt(int distance)
        {
            return new FirstReceiptLevelCaculator().GetLevelReceipt((int)ReceiptLevel.Second) + GetRemainedCharge(distance);
        }

        private double GetRemainedCharge(int distance)
        {
            return GetRemainedDistance(distance) * stepCharge;
        }

        private int GetRemainedDistance(int distance)
        {
            return (distance - (int)ReceiptLevel.Second);
        }
    }
}
