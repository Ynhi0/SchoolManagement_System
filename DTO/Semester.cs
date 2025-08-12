using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Semester
    {
        public string? IdClass { get; set; }
        public DateTime speakingTest { get; set; }
        public DateTime listeningTest { get; set; }
        public DateTime writingTest { get; set; }
        public DateTime readingTest { get; set; }
    }
}
