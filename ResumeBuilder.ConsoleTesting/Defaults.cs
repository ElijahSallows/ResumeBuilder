using ResumeBuilder.ConsoleTesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.ConsoleTesting
{
    internal static class Defaults
    {
        public static DocumentTheme Theme { get; } = new DocumentTheme(new ColorModel()
        {
            Main = "#032f67"
        })
        {

        };
    }
}
