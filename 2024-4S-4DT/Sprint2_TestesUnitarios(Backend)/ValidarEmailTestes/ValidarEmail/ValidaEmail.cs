using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarEmail
    {
    public static class ValidaEmail
        {
        public static bool ValidateEmail(string email)
            {
            return email.Contains("@") && email.Contains(".") && email.Split("@")[0].Length > 5;
            }
        }
    }
