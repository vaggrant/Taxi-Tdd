using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TaxiTdd
{
    internal class RegexConverter
    {
        private Regex regex;

        public RegexConverter(Regex regex)
        {
            this.regex = regex;
        }

        public  MatchConverter GetMatch(string data)
        {
            return new MatchConverter(regex.Match(data));
        }
    }
}
