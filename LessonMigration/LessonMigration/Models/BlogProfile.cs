using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMigration.Models
{
    public class BlogProfile : BaseEntity
    {
        public string Image { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string DateTime { get; set; }
    }
}
