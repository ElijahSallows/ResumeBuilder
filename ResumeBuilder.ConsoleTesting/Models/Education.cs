using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.ConsoleTesting.Models
{
    internal class Education
    {
        public string? SchoolName { get; set; }
        public string? ClassName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<string>? Points { get; set; }
        public bool? Current { get; set; }
    }
}
