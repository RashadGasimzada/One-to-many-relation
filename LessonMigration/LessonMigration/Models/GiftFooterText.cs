using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMigration.Models
{
    public class GiftFooterText : BaseEntity
    {
        public string Text { get; set; }
        public Gift Gift { get; set; }

    }
}
