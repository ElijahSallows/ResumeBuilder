using ResumeBuilder.ConsoleTesting.Models;

namespace ResumeBuilder.ConsoleTesting
{
    internal static class Defaults
    {

        // This class is not yet being used.
        // It will either be used
        // or deleted before MVP.
        public static DocumentTheme Theme { get; } = new DocumentTheme(new ColorModel()
        {
            Main = "#032f67"
        },
            new FontModel())
        {

        };
    }
}
