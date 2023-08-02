using QuestPDF.Helpers;
using ResumeBuilder.Shared;
using ResumeBuilder.Shared.Models;
using ResumeBuilder.Shared.ResumeGeneration;

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
    Main = Fonts.Lato,
    Header = Fonts.Lato,
    Social = Fonts.Lato
};
var theme = new DocumentTheme(colors, fonts);

// DEBUG
//for (int i = 0; i < theme.MaxSkillCount + 2; i++)
//{
//    info.Skills.Info.Add(new Skill("Skill " + i.ToString()));
//}
var builder = new DocumentBuilder(info, theme);
builder.BuildPreview();
//builder.BuildPdf("C:\\Users\\elija\\OneDrive\\Desktop\\ResumeBuilder\\resume.pdf");