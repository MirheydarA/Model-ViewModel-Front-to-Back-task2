using FrontToBacktask2.Models;

namespace FrontToBacktask2.ViewModels.About
{
    public class AboutIndexViewModel
    {
        public List<AboutUs> AboutUs { get; set; }
        public List<OurTeam> OurTeams { get; set; }
        public List<Progress> Progress { get; set; }
        public List<Choose> Choose { get; set; }
        public List<Mission> missions { get; set; }
        public List<Contact> Contact { get; set; }
    }
}
