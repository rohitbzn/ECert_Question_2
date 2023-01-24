using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ECert_Question_2
{
    public class DuplicateHelper
    {
        public string DuplicateFinder(string input)
        {
            var matches = Regex.Matches(input, @"(.)\1+");
            for (int i = 0; i < matches.Count; i++)
            {
                return $"position of {matches[i].Value.Substring(0, 1)} is {matches[i].Index} and value is {matches[i].Value}";
            }
            return "";
        }
    }
}
