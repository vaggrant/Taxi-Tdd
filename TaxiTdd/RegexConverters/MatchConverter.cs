using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TaxiTdd
{
    internal class MatchConverter
    {
        private Match match;

        public MatchConverter(Match match)
        {
            this.match = match;
        }

        public GroupConverter GetGroup(int index)
        {
            return new GroupConverter(match.Groups[index]);
        }
    }
}
