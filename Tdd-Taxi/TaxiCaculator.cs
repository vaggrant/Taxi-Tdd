using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiTdd;

namespace Tdd_Taxi
{
    internal class TaxiCaculator
    {
        private FileReader fileReader;

        public TaxiCaculator(string fileName)
        {
            fileReader = new FileReader(fileName);
        }

        public string GetTaxiReceipt()
        {
            return string.Join("\n", fileReader.GetDatas().Select(d => $"收费{d.GetReceipt()}元"));
        }
    }
}
