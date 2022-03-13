using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMigration.Models
{
    public class FlowerExpertProfile : BaseEntity
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
    }
}
