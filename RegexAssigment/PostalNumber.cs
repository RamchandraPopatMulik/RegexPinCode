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
        public static string REGIX_PINCODE = "^[1-9][0-9]{5}$";
        public bool validatePinCode(string pincode)
        {
            return Regex.IsMatch(pincode, REGIX_PINCODE);
        }
    }
}
