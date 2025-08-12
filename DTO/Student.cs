using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Student
    {
        public string? IDS { get; set; }
        public int IDUser { get; set; }
        public string? IDClass { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public DateTime BornDate { get; set; }
        public string? States { get; set; }
        public int TuitionFee { get; set; }
        public DateTime DueDate { get; set; }
        public int Month { get; set; }
    }
}
