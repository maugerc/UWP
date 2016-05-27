using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestComp.Entities
{
    public class Skill
    {
        public Guid SkillId { get; set; }

        public string Label { get; set; }

        public double Note { get; set; }
    }
}
