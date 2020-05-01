using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TaxiTdd
{
    internal class GroupConverter
    {
        private Group group;

        public GroupConverter(Group group)
        {
            this.group = group;
        }

        public int GetValue()
        {
            return int.Parse(group.Value);
        }
    }
}
