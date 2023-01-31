﻿// I'm doing a relatively quick learning of QuestPDF
// and a mockup design of the resume format I may use.
// I'm aware that there should be more comments.
// I'll address that as I go along. :)
using ResumeBuilder.ConsoleTesting;
using ResumeBuilder.ConsoleTesting.Models;
using ResumeBuilder.ConsoleTesting.Properties;

Console.WriteLine("Hello, World!");


var info = new ResumeInfo()
{
    User = new UserInfo()
    {
        About = "about.\n it's all about me",
        Email = "test@email.com",
        Phone = "(309)-xxx-xxxx",
        Name = "Elijah Sallows",
        Title = "Junior .NET Developer",
        Links = new List<SocialLink>
        {
            new SocialLink()
            {
                Url = "https://www.linkedin.com/",
                Image = Resources.linkedin,
                Name = "LinkedIn"
            },
            new SocialLink()
            {
                Url = "Link.Url-2",
                Image = Resources.github,
                Name = "GitHub"
            },
            new SocialLink()
            {
                Url = "Link.Url-2",
                Image = Resources.gmail,
                Name = "email :)"
            }

        },
        Address = new Address()
        {
            City = "Gilbert",
            State = "AZ",
            Zip = "85233"
        }
    },
    Education = new EducationInfo()
    {
        Education = new List<Education>()
        {
            new Education()
            {
                StartDate = DateTime.Now,
                SchoolName = "Current Work",
                ClassName = "Software Developer",
                Current = true,
                Points = new List<string>()
                {
                    "work here now",
                    "happy face :)"
                }
            },

            new Education()
            {
                EndDate = DateTime.Now,
                StartDate = DateTime.Now,
                SchoolName = "Previous Work",
                ClassName = "Not a Software Developer",
                Current = false,
                Points = new List<string>()
                {
                    "worked here",
                    "don't anymore"
                }
            }
        }
    },
    Experience = new ExperienceInfo()
    {
        Experiences = new List<Experience>()
        {
            new Experience()
            {
                StartDate = DateTime.Now,
                CompanyName = "Current Work",
                Title = "Software Developer",
                Current = true,
                Points = new List<string>()
                {
                    "work here now",
                    "happy face :)"
                }
            },

            new Experience()
            {
                EndDate = DateTime.Now,
                StartDate = DateTime.Now,
                CompanyName = "Previous Work",
                Title = "Not a Software Developer",
                Current = false,
                Points = new List<string>()
                {
                    "worked here",
                    "don't anymore"
                }
            }
        }
    },
    Projects = new ProjectsInfo()
    {

    },
    Skills = new SectionInfo<Skill>()
    {
        Bullets = new List<Skill>()
        {
            new Skill("C#"),
            new Skill("HTML / CSS"),
            new Skill("a"),
            new Skill("b"),
            new Skill("c"),
            new Skill("d"),
            new Skill("e")
        }
    }
};

var colors = new ColorModel()
{
    Main = "#032f67",
    Secondary = "#E0FBFC",
    Tertiary = "#E0FBFC",
    Quaternary = "#9DB4C0",
    Background = "#FFFFFF",
    BottomContrast = "#2C6E49"
};
var theme = new DocumentTheme(colors);

var builder = new DocumentBuilder(info, theme);
builder.Build();