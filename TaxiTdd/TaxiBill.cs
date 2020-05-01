using System;

namespace TaxiTdd
{
    public class TaxiBill
    {
        public int Distance { get; set; }
        public int WaitingTime { get; set; }
        public override bool Equals(object obj)
        {
            var taxiBill = (TaxiBill)obj;
            return taxiBill.Distance == this.Distance && taxiBill.WaitingTime == this.WaitingTime;
        }

        public int GetReceipt()
        {
            double receiptPart2 = WaitingTime * 0.25;
            ReceiptLevelCaculator receiptLevelCaculator = GetPart1Caculator();
            return (int)Math.Round(receiptLevelCaculator.GetLevelReceipt(Distance) + receiptPart2);
        }

        private ReceiptLevelCaculator GetPart1Caculator()
        {
            ReceiptLevelCaculator receiptLevelCaculator;
            if (Distance <= (int)ReceiptLevel.Second)
            {
                receiptLevelCaculator = new FirstReceiptLevelCaculator();
            }
            else if (Distance <= (int)ReceiptLevel.Third)
            {
                receiptLevelCaculator = new SecondReceiptLevelCaculator();
            }
            else
            {
                receiptLevelCaculator = new ThirdReceiptLevelCaculator();
            }
            return receiptLevelCaculator;
        }
    }
}