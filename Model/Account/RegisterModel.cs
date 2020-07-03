using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen2.Model.Account
{
    public struct RegisterModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Password1 { get; set; }
    }
}
