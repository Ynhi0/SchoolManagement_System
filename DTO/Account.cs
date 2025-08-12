using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public string? Username { get; set; }
        public string? Password { get; set; }

        public int Iduser { get; set; }
        public string? DisplayName { get; set; }
        public string? ClassID { get; set; }
        public string? Role { get; set; }
    }
}
