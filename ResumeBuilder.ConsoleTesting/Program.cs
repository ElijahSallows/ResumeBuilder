// I'm doing a relatively quick learning of QuestPDF
// and a mockup design of the resume format I may use.
// I'm aware that there should be more comments.
// I'll address that as I go along. :)
using QuestPDF.Helpers;
using ResumeBuilder.ConsoleTesting;
using ResumeBuilder.ConsoleTesting.Properties;
using ResumeBuilder.Shared;
using ResumeBuilder.Shared.Models;

Console.WriteLine("Hello, World!");


var info = MockResumeInfo.GetInfo();

var colors = new ColorModel()
{
    Main = "#032f67",
    Secondary = "#E0FBFC",
    Tertiary = "#C2DFE3",
    Quaternary = "#9DB4C0",
    Background = "#FFFFFF",
    LightContrast = "#EEEEEE",
    MediumContrast = "#CCCCCC",
    DarkContrast = "#777777",
    BottomContrast = "#2C6E49",
    Subfocus = "#424242"
};
var fonts = new FontModel()
{
    Main = Fonts.Tahoma,
    Header = Fonts.Tahoma,
    Social = Fonts.Tahoma
};
var theme = new DocumentTheme(colors, fonts);

// DEBUG
for (int i = 0; i < theme.MaxSkillCount + 2; i++)
{
    info.Skills.Info.Add(new Skill("Skill " + i.ToString()));
}
var builder = new DocumentBuilder(info, theme);
builder.Build();