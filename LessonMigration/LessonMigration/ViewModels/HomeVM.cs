using LessonMigration.Models;
using System.Collections.Generic;

namespace LessonMigration.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public SliderDetail Detail { get; set; }
        public List<Gift> Gifts { get; set; }
        public FlowerExpertsTitle FlowerExpertsTitle { get; set; }
        public List<FlowerExpertProfile> FlowerExpertProfiles { get; set; }
        public BlogTitle BlogTitle { get; set; }
        public List<BlogProfile> BlogProfiles { get; set; }
        public List<IGAccount> IGAccounts { get; set; }
    }
}
