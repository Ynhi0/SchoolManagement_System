using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Salary
    {
        public string? ID { get; set; }
        public string? IDTEACHER { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int WorkingHours { get; set; }
        public string? Status { get; set; }
        public int Total { get; set; }
    }
}
