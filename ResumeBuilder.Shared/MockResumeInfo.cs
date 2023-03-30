using ResumeBuilder.Shared.Interfaces;
using ResumeBuilder.Shared.Models;
using ResumeBuilder.Shared.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Shared
{
    public static class MockResumeInfo
    {
        public static IResumeInfoModel GetInfo()
        {
            return new ResumeInfoModel()
            {
                User = new UserInfoModel()
                {
                    About = "about.\n it's all about me",
                    Email = "test@email.com",
                    Phone = "(309)-xxx-xxxx",
                    Name = "Elijah Sallows",
                    Title = "Junior .NET Developer",
                    Links = new List<ISocialLink>
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
                Education = new List<IEducation>()
    {
        new Education()
        {
            StartDate = DateTime.Now,
            SchoolName = "Current Work",
            //ClassName = "Software Developer",
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
            //ClassName = "Not a Software Developer",
            Current = false,
            Points = new List<string>()
            {
                "worked here",
                "don't anymore"
            }
        }
    },
                Experiences = new List<IExperience>()
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
            },
            new Experience()
            {
                StartDate = DateTime.Now,
                CompanyName = "idk 1",
                Title = "debug :)",
                Current = true,
                Points = new List<string>()
                {
                    "what is it?",
                    "bullet 2 I suppose"
                }
            },
            new Experience()
            {
                StartDate = DateTime.Now,
                CompanyName = "idk 2",
                Title = "debug to test limit. Shouldn't be visible.",
                Current = true,
                Points = new List<string>()
                {
                    "work here now",
                    "happy face :)"
                }
            }

    },
                Projects = new List<IProject>()
    {
        new Project()
        {
            Name = "Project 1",
            Date = "Feb 2023",
            Points = new List<string>()
            {
                "this thing"
            }
        },
        new Project()
        {
            Name = "Project 2",
            Date = "date",
            Points = new List<string>()
            {
                "a couple",
                "of points"
            }
        },
        new Project()
        {
            Name = "Project 3",
            Date = "yesterday",
            Points = new List<string>()
            {
                ":) :)",
                ":("
            }
        }
    },
                Skills = new SectionInfo<ISkill>()
                {
                    Bullets = new List<ISkill>()
                    {
                        //new Skill("C#"),
                        //new Skill("HTML / CSS"),
                        //new Skill("a"),
                        //new Skill("b"),
                        //new Skill("c"),
                        //new Skill("d"),
                        //new Skill("e")
                    }
                }
            };
        }
    }
}
