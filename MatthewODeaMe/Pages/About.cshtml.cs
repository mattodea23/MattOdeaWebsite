using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MatthewODeaMe.Pages
{
    public class AboutModel : PageModel
    {
        public String[] SkillsAndAbil;
        public AwardsAndQualifications[] AwardAndQual;

        public void OnGet()
        {
            SkillsAndAbil = SetSkillsAndAbil();
            AwardAndQual = SetAwardAndQual();
        }

        private string[] SetSkillsAndAbil()
        {
            return new String[]
            {
                "Polite, respectful and trustworthy",
                "Great communication and mathematical skills, both written and verbal",
                "Knowledge of various computer languages including Object Oriented Programming, Markup and Styling",
                "Experience with frameworks including ASP.Net Core and Ruby on Rails",
                "Have extensively worked with IDE’s including Visual Studio, Net Beans",
                "Experienced with basic source control",
                "Able to work in a team environment or independently",
                "Ask questions to ensure I am understanding tasks to the full extent",
                "Complete the task as efficiently as possible"
            };
        }

        public class AwardsAndQualifications
        {
            public String Year { get; set; }
            public String AwardOrQual { get; set; }

            public AwardsAndQualifications(String _Year, String _AwardOrQual)
            {
                Year = _Year;
                AwardOrQual = _AwardOrQual;
            }
        }

        private AwardsAndQualifications[] SetAwardAndQual()
        {
            return new AwardsAndQualifications[]
            {
                new AwardsAndQualifications("2017", "Diploma of Software Development (Due to complete December 2017)"),
                new AwardsAndQualifications("2017", "Certificate of Excellence for Diploma of Software Development"),
                new AwardsAndQualifications("2016", "Certificate IV of Programming"),
                new AwardsAndQualifications("2015", "Graduation Certificate, Emmanuel Catholic College Success"),
                new AwardsAndQualifications("2015", "Community/Christian Services Certificate"),
                new AwardsAndQualifications("2015", "Certificate II of Hospitality"),
                new AwardsAndQualifications("2015", "Certificate II of Business"),
                new AwardsAndQualifications("2015", "Certificate II of Information Technology"),
                new AwardsAndQualifications("2014", "Work Safe: General and Retail Industry Modules"),
                new AwardsAndQualifications("2014", "Work Safe: General and Hospitality & Tourism Industry Modules"),
                new AwardsAndQualifications("2013", "Excellent Work Attitudes and Habit, Year 10 Semester 1"),
                new AwardsAndQualifications("2013", "Excellent Work Attitudes and Habits, Year 10 Semester 2"),
              
            };
        }
    }
}
