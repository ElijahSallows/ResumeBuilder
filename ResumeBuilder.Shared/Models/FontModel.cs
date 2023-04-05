using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumeBuilder.Shared.Interfaces;

namespace ResumeBuilder.Shared.Models
{
    public class FontModel : IFontModel
    {
        public required string Main { get; set; }
        public required string Header { get; set; }
        public required string Social { get; set; }
    }
}
