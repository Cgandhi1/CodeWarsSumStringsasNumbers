using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp18
{
    [Serializable]
    class Program
    {
        static void Main(string[] args)
        {

            string a = "44444444444444444444444444444444444444";
            string b = "1";

            string numeric1 = "";
            string numeric2 = "";

            if (a == "")
            {
                numeric1 = "0";
            }

            if (b == "")
            {
                numeric2 = "0";
            }

            if (a.Any(char.IsDigit) == true)
            {
                numeric1 = new string(a.Where(c => char.IsDigit(c)).ToArray());
            }
            else
            {
                numeric1 = "0";
            }

            if (b.Any(char.IsDigit) == true)
            {
                numeric2 = new string(b.Where(c => char.IsDigit(c)).ToArray());
            }
            else
            {
                numeric2 = "0";
            }

            try
            {
                decimal trynuma = decimal.Parse(numeric1);
                decimal trynumb = decimal.Parse(numeric2);
                decimal numtotal = trynuma + trynumb;
                string str = Convert.ToString(numtotal);
                Console.WriteLine(str);
                Console.ReadLine();
            }
            catch
            {
                BigInteger trynuma = BigInteger.Parse(numeric1);
                BigInteger trynumb = BigInteger.Parse(numeric2);
                BigInteger numtotal = trynuma + trynumb;
                string str = Convert.ToString(numtotal);
                Console.WriteLine(str);
                Console.ReadLine();
            }
           
           
            
            





        }
    }
}
