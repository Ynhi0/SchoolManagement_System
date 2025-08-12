using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StudentScore
    {
        public string? IDS { get; set; }
        public string? IdClass { get; set; }
        public int ReadScore { get; set; }
        public int ListenScore { get; set; }
        public int SpeakScore { get; set; }
        public int TotalScore { get; set; }
    }
}
