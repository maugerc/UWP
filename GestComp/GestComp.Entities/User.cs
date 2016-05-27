using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestComp.Entities
{
    public class User
    {
        public Guid UserId { get; set; }

        public string Key { get; set; }

        public List<Skill> Skills { get; set; }
    }
}
