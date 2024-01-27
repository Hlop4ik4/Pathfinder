using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderDatabaseImplement.Models
{
    public class ProfessionSkillLevels
    {
        public int Id { get; set; }

        public int ProfessionId { get; set; }

        public int SkillLevelId { get; set; }

        public virtual Profession Profession { get; set; }

        public virtual SkillLevel SkillLevel { get; set; }
    }
}
