using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Users
    {
        public int IDUSER { get; set; }
        public string? USERNAME { get; set; }
        public string? Passwords { get; set; }
        public string? DisplayName { get; set; }
        public string? ROLE { get; set; }
    }
}