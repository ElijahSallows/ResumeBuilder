﻿using ResumeBuilder.Shared.Models;
using ResumeBuilder.Shared.Properties;

namespace ResumeBuilder.Shared
{
    public static class MockResumeInfo
    {
        public static ResumeInfoModel GetInfo()
        {
            return new ResumeInfoModel()
            {
                User = new Section<UserInfoModel>()
                {
                    Info = new()
                    {
                        About = "about.\n it's all about me",
                        Email = "test@email.com",
                        Phone = "(309)-xxx-xxxx",
                        Name = "Elijah Sallows",
                        Title = "Junior .NET Developer",
                        Links = new List<SocialLink>()
                        {
                            new SocialLink()
                            {
                                Url = "www.linkedin.com/",
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
                            //,
                            //new SocialLink()
                            //{
                            //    Url = "Link.Url-2",
                            //    Image = Resources.gmail,
                            //    Name = "email :)"
                            //},
                            //new SocialLink()
                            //{
                            //    Url = "Link.Url-2",
                            //    Image = Resources.gmail,
                            //    Name = "email :)"
                            //},
                            //new SocialLink()
                            //{
                            //    Url = "Link.Url-2",
                            //    Image = Resources.gmail,
                            //    Name = "email :)"
                            //},
                            //new SocialLink()
                            //{
                            //    Url = "Link.Url-2",
                            //    Image = Resources.upwork,
                            //    Name = "Shouldn't be seen!"
                            //}
                        }
                    }
                },
                Address = new Section<Address>()
                {
                    Info = new()
                    {
                        City = "Gilbert",
                        State = "AZ",
                        Zip = "85233"
                    }
                },
                Education = new Section<List<Education>>()
                {
                    Info = new()
                    {
                        new Education()
                        {
                            StartDate = DateTime.Now,
                            SchoolName = "Current Work",
                            //ClassName = "Software Developer",
                            EndDate = DateTime.Now,
                            Current = true,
                            Points = new List<string>()
                            {
                                "work here now",
                                "happy face :)"
                            },
                            Title = "title :)"
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
                            },
                            Title = "title :)"
                        }
                    }
                },
                Experiences = new Section<List<Experience>>()
                {
                    Info = new()
                    {
                        new Experience()
                        {
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now,
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
                            EndDate = DateTime.Now,
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
                            EndDate = DateTime.Now,
                            CompanyName = "idk 2",
                            Title = "debug to test limit. Shouldn't be visible.",
                            Current = true,
                            Points = new List<string>()
                            {
                                "work here now",
                                "happy face :)"
                            }
                        }
                    }

                },
                Projects = new Section<List<Project>>()
                {
                    Info = new()
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
                    }
                },
                Skills = new Section<List<Skill>>()
                {
                    Info = new()
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
        }
    }
}
