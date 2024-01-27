using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderDatabaseImplement.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual List<EmployeeSkillLevels> EmployeeSkillLevels { get; set; }
    }
}
