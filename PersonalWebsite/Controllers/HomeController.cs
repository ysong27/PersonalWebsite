using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using PersonalWebsite.Models;
using System.Diagnostics;

namespace PersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Resume()
        {
            List<Education> educations = new List<Education>()
            {
                new Education(1, "Computer Programming & Analysis", "seneca-logo.svg", new DateTime(2021, 1, 1), DateTime.Now, 
                    new List<string>() 
                    { 
                        "President’s Honour List (GPA: 4.0 / 4.0)" 
                    }, 
                    "Toronto", "ON"),
                new Education(2, "Master of Management", "Schulich_York_Logo_Footer.svg", new DateTime(2018, 9, 1), new DateTime(2019, 10, 1),
                    new List<string>()
                    { 
                        "Business Administration and Management"
                    },
                    "Toronto", "ON"),
                new Education(3, "Honours Bachelor of Science", "University_of_Toronto-Logo.wine.svg", new DateTime(2013, 9, 1), new DateTime(2018, 6, 1),
                    new List<string>()
                    { 
                        "Life Science (Cell and Systems Biology)"
                    },
                    "Toronto", "ON")
            };
            List<Work> works = new List<Work>()
            {
                new Work(1, "Software Developer", "alpha-logo.svg", new DateTime(2021, 12, 1), DateTime.Now,
                    new List<string>()
                    {
                        "Developed new .NET web application features and maintained existing application codebase",
                        "Developed new and updated existing automation tests using Selenium WebDriver in Java",
                        "Performed web vulnerability scanning using Burp Suite, reported, and remediated discovered vulnerabilities",
                        "Participated in mobile app development using React-Native for iOS and Android",
                        "Documented modifications to system descriptions and user manuals for existing web applications"
                    },
                    "Toronto", "ON"),
                new Work(2, "Inventory Coordinator", "brafasco_logo_55.png", new DateTime(2020, 12, 1), new DateTime(2021, 4, 1),
                    new List<string>()
                    {
                        "Evaluated and established inventory planning on items requested by branch locations and category management team based on inventory data in MS Dynamics GP and inventory management policies",
                        "Analyzed inventory transfer and return requests from branch locations and made recommendations based on inventory management policies"
                    },
                    "Vaughan", "ON"),
                new Work(3, "Inventory Associate", "canadas-wonderland-header-logov3.png", new DateTime(2020, 2, 1), new DateTime(2020, 8, 1),
                    new List<string>() 
                    {
                        "Maintained data accuracy and consistency between MP2 database and physical inventory by updating changes in inventory data and investigating record discrepancies",
                        "Analyzed historic inventory data in MP2 database and built Excel spreadsheet model that estimated inventory replenishment timing and quantities to aid purchasing decision"
                    },
                    "Vaughan", "ON")
            };
            List<Certification> certifications = new List<Certification>()
            {
                new Certification(1, "Certified Supply Chain Professional (CSCP)", "ascm-logo-1.svg", new DateTime(2021, 2, 1), new DateTime(2026, 2, 1),
                    new List<string>() 
                    {
                        "Credential ID: 165388"
                    })
            };

            ViewBag.Educations = educations;
            ViewBag.Works = works;
            ViewBag.Certifications = certifications;

            return View();
        }

        public IActionResult Project()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}