using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderDatabaseImplement.Models
{
    public class EmployeeSkillLevels
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int SkillLevelId { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual SkillLevel SkillLevel { get; set; }
    }
}
