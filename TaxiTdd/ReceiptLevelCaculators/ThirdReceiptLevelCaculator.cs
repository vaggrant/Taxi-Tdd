using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiTdd
{
    internal class ThirdReceiptLevelCaculator : ReceiptLevelCaculator
    {
        private double stepCharge = 1.2;
        public override double GetLevelReceipt(int distance)
        {
            return new SecondReceiptLevelCaculator().GetLevelReceipt((int)ReceiptLevel.Third) + GetRemainedCharge(distance);
        }

        private double GetRemainedCharge(int distance)
        {
            return GetRemainedDistance(distance) * stepCharge;
        }

        private int GetRemainedDistance(int distance)
        {
            return (distance - (int)ReceiptLevel.Third);
        }
    }
}
