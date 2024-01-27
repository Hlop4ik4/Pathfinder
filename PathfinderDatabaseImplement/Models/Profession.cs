using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderDatabaseImplement.Models
{
    public class Profession
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("ProfessionId")]
        public virtual List<ProfessionSkillLevels> ProfessionSkillLevels { get; set; }
    }
}
