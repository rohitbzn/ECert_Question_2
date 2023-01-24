using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ECert_Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string with duplicate characters.");
            string input = Console.ReadLine();
            DuplicateHelper duplicateHelper = new DuplicateHelper();
            // find duplicates and show the index and value within the string
            var dups = duplicateHelper.DuplicateFinder(input);
            // write to console 
            Console.WriteLine(dups);
            Console.Read();
        }

        
    }
}
