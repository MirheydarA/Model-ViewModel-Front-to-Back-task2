using FrontToBacktask2.Models;
using FrontToBacktask2.ViewModels.About;
using Microsoft.AspNetCore.Mvc;

public class AboutController : Controller
    {
        public IActionResult Index()
        {
        var aboutus = new List<AboutUs>
            {
                new AboutUs {Title = "About Us", Description = "Vector illustration credit goes to FreePik website. Purple Buzz is provided by TemplateMo. Lorem ipsum dolor sit amet, consectetur.", PhotoPath = "/assets/img/banner-img-02.svg"}
            };

        var ourteams = new List<OurTeam>
        {
            new OurTeam {Title = "Our Team", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", PhotoPath1 = "/assets/img/team-01.jpg", PhotoName1 = "John Doe", PhotoWork1 = "Business Development", PhotoPath2 = "/assets/img/team-02.jpg", PhotoName2 = "Jane Doe", PhotoWork2 = "Media Development", PhotoPath3 = "/assets/img/team-03.jpg", PhotoName3 ="Sam", PhotoWork3= "Developer" }
        };

        var progress = new List<Progress>
        {
            new Progress {Id = 1, Title = "Creative & Make Perfect", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse ultrices gravida Risus."}
        };

        var choose = new List<Choose>
        {
            new Choose {Id = 1, Title ="Why you choose us?", Description = "You are allowed to download and use this Purple Buzz template for your websites. You are not allowed to re-distribute this template ZIP file on other template websites. It is quite easy to simply copy and repost the ZIP file on any Free CSS collection websites.", PhotoPath = "/assets/img/work.svg"}
        };

        var missions = new List<Mission>
        {
            new Mission {Id = 1, Title = "Our Vision", Description = "Incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse commodo viverra."},
            new Mission {Id = 2, Title = "Our Mission", Description = "Eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis."},
            new Mission {Id = 3, Title = "Our Goalsss" , Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor."}
        };

        var contact = new List<Contact>
        {
            new Contact { Title = "Stay up to date with us", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt labore et dolore magna aliqua."}
        };

        var model = new AboutIndexViewModel
        {
            AboutUs = aboutus,
            OurTeams = ourteams,
            Progress = progress,
            Choose = choose,
            missions = missions,
            Contact = contact
        };
            
        
        return View(model);
        }
    }

