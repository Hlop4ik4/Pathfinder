using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderDatabaseImplement.Models
{
    public class SkillLevel
    {
        public int Id { get; set; }

        public int SkillId { get; set; }

        public int Level { get; set; }

        [ForeignKey("SkillLevelId")]
        public virtual List<ProfessionSkillLevels> ProfessionSkillLevels { get; set; }

        [ForeignKey("SkillLevelId")]
        public virtual List<EmployeeSkillLevels> EmployeeSkillLevels { get; set; }

        public virtual Skill Skill { get; set; }
    }
}
