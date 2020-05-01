using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace TaxiTdd
{
    public class FileReader
    {
        private string testDataFile;

        private string GetAbsoluateFileName(string v) => $"{AppDomain.CurrentDomain.BaseDirectory}\\{v}";

        public FileReader(string v)
        {
            testDataFile = GetAbsoluateFileName(v);          
        }

        private TaxiBill GetTaxiBill(string line, Regex regex)
        {
            return new TaxiBill
            {
                Distance = new RegexConverter(regex).GetMatch(line).GetGroup(1).GetValue(),
                WaitingTime = new RegexConverter(regex).GetMatch(line).GetGroup(2).GetValue(),
            };
        }

        public List<TaxiBill> GetDatas()
        {
            if (File.Exists(testDataFile))
            {
                string[] fileLines = File.ReadAllLines(testDataFile);
                Regex regex = new Regex("([1-9][0-9]*)公里,等待([0-9]*)分钟");
                return fileLines.Where(l => regex.IsMatch(l)).Select(l => GetTaxiBill(l, regex)).ToList();
            }
            return default(List<TaxiBill>);
        }
    }
}