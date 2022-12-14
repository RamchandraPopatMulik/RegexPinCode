using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssigment
{
    public class PostalNumber
    {
        public void ValidatePinCode(string pincode)
        {
            var ragex = new Regex("^[1-9]{1}[0-9]{2}\\s{0,1}[0-9]{3}$");
            bool matchRes = ragex.IsMatch(pincode);
            if (matchRes == true)
            {
                Console.WriteLine($"\n{pincode} Matches the PinCode");
            }
            else
            {
                Console.WriteLine($"\n{pincode} does not matches the PinCode");
            }
        }
    }
}
