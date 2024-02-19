using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Models
{
    internal class UserData
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int Phonenumber { get; set; }
        public bool Newsletter { get; set; }
    }
}
