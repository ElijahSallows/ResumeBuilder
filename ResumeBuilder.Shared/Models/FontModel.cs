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
        public string Main { get; set; }
        public string Header { get; set; }
        public string Social { get; set; }
    }
}
