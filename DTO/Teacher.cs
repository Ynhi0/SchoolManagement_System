using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Teacher
    {
        public int IDUSER { get; set; }
        public string? IDTEACHER { get; set; }
        public string? NAMEOFTEACHER { get; set; }
        public string? BORNDATE { get; set; }
        public string? GENDER { get; set; }
        public string? ADDRESSOFTEACHER { get; set; }
        public int SALARY { get; set; }
        public string? PHONE { get; set; }
        public string? STATUS { get; set; }
        public decimal SALARYCOEFFICIENT { get; set; }
    }
}
