using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Score
    {
        public string? studentID { get; set; }
        public string? IdClass { get; set; }
        public string? name { get; set; }
        public int readScore { get; set; }
        public int listenScore { get; set; }
        public int writeScore { get; set; }
        public int speakScore { get; set; }
        public int totalScore { get; set; }
        public string? className { get; set; }
    }
}
