using ResumeBuilder.ConsoleTesting.Models;

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
