using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexforEmail
{
    class UserRegistrastion

    {
        const string EMAIL_PATTERN = "^[a-z]{2,}[+][0-9]{1,3}[@][a-z]{3,}[.][a-z]{3,}$";
       

        public bool ValidateEmail(string email)
        {
            var result = Regex.Match(email, EMAIL_PATTERN);
            if (result.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
