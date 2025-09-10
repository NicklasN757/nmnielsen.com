using Microsoft.AspNetCore.Mvc.RazorPages;

namespace nmnielsen.web.Pages
{
    public class ResumeModel : PageModel
    {
        public List<ExperienceItem> WorkExperienceItems { get; set; }
        public List<ExperienceItem> EducationExperienceItems { get; set; }
        public List<ExperienceItem> SideProjectsItems { get; set; }
        public List<ExperienceItem> VolunteeringExperienceItems { get; set; }

        public void OnGet()
        {
            // Work Experience
            WorkExperienceItems = new List<ExperienceItem>
            {
                new ExperienceItem
                {
                    Company = "Danfoss A/S",
                    Title = "Junior Cloud Developer",
                    Location = "Kolding, Denmark",
                    Period = "01.02.2024 – 31.05.2025",
                    Bullets = new List<string>
                    {
                        "Collaborated with external contractors to develop two APIs for internal employee management and product availability.",
                        "Designed and implemented features to improve data accessibility for teams and customers.",
                        "Maintained and optimized our Azure DevOps pipeline for efficiency.",
                        "Improved code quality by integrating linting, testing, and version control into our pipelines."
                    },
                    IsTopBorder = false
                },
                new ExperienceItem
                {
                    Company = "Danfoss Drives A/S",
                    Title = "Apprentice",
                    Location = "Graasten, Denmark",
                    Period = "01.02.2020 – 01.02.2024",
                    Bullets = new List<string>
                    {
                        "Developed web projects using Razor Pages, handling both front-end and back-end.",
                        "Designed and set up databases, ensuring smooth integration with Entity Framework and LINQ.",
                        "Oversaw the full setup and integration, ensuring optimal performance and scalability.",
                        "Worked with multiple teams on challenging projects like a pizza delivery robot, a Bluetooth speaker, and a game console."
                    },
                    IsTopBorder = true
                }
            };

            // Educational Experience
            EducationExperienceItems = new List<ExperienceItem>
            {
                new ExperienceItem
                {
                    Company = "Journeyman's Certificate (Svendebrev)",
                    Title = "Data technician, specializing in programming",
                    Location = "Sønderborg & Viborg, Denmark",
                    Period = "01.08.2018 - 01.02.2024",
                    Bullets = new List<string>
                    {
                        "Introductory courses in Data and communication, part one and two taken at Mercantec in Viborg.",
                        "Main course (H1) taken at Mercantec in Viborg.",
                        "Main courses (H2-H5) taken at EUC Syd in Sønderborg.",
                        "Final exam and journeyman's test taken at EUC Syd in Sønderborg.",
                        "Apprenticeship at Danfoss Drives A/S in Graasten."
                    }

                },
                new ExperienceItem
                {
                    Company = "Certifications",
                    Title = "Check LinkedIn for more information",
                    Location = "",
                    Period = "",
                    Bullets = new List<string>
                    {
                        "Azure Fundamentals (AZ-900)",
                        "Azure AI Fundamentals (AI-900)",
                        "Foundational C# with Microsoft",
                        "Secure coding (Semgrep Academy)",
                        "Incident Response for Software Developers (Semgrep Academy)",
                        "API Designer (API Academy)",
                        "API Security Architect (API Academy)",
                        "API Product Manager (API Academy)"
                    },
                    IsTopBorder = true
                }
            };

            // Side Projects
            SideProjectsItems = new List<ExperienceItem>
            {
                new ExperienceItem
                {
                    Company = "WFM-Alerter",
                    Title = "Open source (GNU v3.0)",
                    Location = "Status:",
                    Period = "Complete",
                    Bullets = new List<string>
                    {
                        "This project began while some friends and I were playing Warframe. I noticed the unofficial market lacked a way to notify players when desired in-game items became available at a specific price.",
                        "The solution runs as a single Azure Function app, using an embedded SQLite database to track user-created alerts. Azure Mail services handle player notifications.",
                        "Source code is available on GitHub.",
                        "Project is complete but, have plans for adding a web interface to allow users to create alerts more easily."
                    }
                },
                new ExperienceItem
                {
                    Company = "Mobile App",
                    Title = "Closed source project",
                    Location = "Status:",
                    Period = "In development",
                    Bullets = new List<string>
                    {
                        "I started the project while working at Danfoss as a consultant, aiming to create a smartphone-based flex time tracker to monitor my working hours.",
                        "Developed using .NET MAUI, which simplifies cross-platform deployment to Windows and iOS.",
                        "Planning to publish the app on Android and iOS in the future."
                    },
                    IsTopBorder = true
                },
                new ExperienceItem
                {
                    Company = "Business Website",
                    Title = "Closed source project",
                    Location = "Status:",
                    Period = "Discontinued",
                    Bullets = new List<string>
                    {
                        "The owner needed a website for a newly started business and wanted to be able to post blogs, reviews, and offers. The site was integrated with Microsoft Entra ID to allow for login and future Azure integration.",
                        "Developed using ASP.NET and using an independent SQL database hosted in Azure.",
                        "Project discontinued due to the owner's loss of interest."
                    },
                    IsTopBorder = true
                }
            };

            // Volunteering Experience
            VolunteeringExperienceItems = new List<ExperienceItem>
            {
                new ExperienceItem
                {
                    Company = "Danish Naval Home Guard",
                    Title = "Deckhand",
                    Location = "Sønderborg, Denmark",
                    Period = "01.01.2021 – 30.04.2025",
                    Bullets = new List<string>
                    {
                        "Trained as a deckhand.",
                        "Participated in various training exercises as well as rescue and environmental operations."
                    }
                },
                new ExperienceItem
                {
                    Company = "Danish Emergency Services",
                    Title = "First aid responder & helper",
                    Location = "Viborg, Denmark",
                    Period = "01.01.2019 – 01.02.2020",
                    Bullets = new List<string>
                    {
                        "First aid responder at different major events.",
                        "Assisting the fire department in the event of major fires"
                    },
                    IsTopBorder = true
                }
            };
        }
    }
}