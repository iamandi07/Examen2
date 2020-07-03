using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen2.Model.Account
{
    public class Token
    {
        public string Value { get; set; }
        public DateTime Expiry { get; set; }
        public string Email { get; set; }
    }
}
