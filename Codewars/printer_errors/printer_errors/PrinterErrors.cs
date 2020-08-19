using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace printer_errors
{
    public class PrinterErrors
    {
        //static void Main(string[] args)
        //{
        //    //Console.WriteLine(PrinterError("aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz"));
        //}

        public string PrinterError(String s)
        {
            int errorCount = Regex.Matches(s, @"[n-z]").Count; ; 
            int charCount = s.Count();
            string result = $"{errorCount}/{charCount}";

            return result;
        }        
    }
}
