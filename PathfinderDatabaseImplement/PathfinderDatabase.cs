using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathfinderDatabaseImplement.Models;

namespace PathfinderDatabaseImplement
{
    public class PathfinderDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=BEST-KOMP\SQLEXPRESS;Initial Catalog=Pathfinder;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            }
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<EmployeeSkillLevels> EmployeeSkillLevels { get; set; }

        public virtual DbSet<Profession> Professions { get; set; }

        public virtual DbSet<ProfessionSkillLevels> ProfessionSkillLevels { get; set; }

        public virtual DbSet<Skill> Skills { get; set; }

        public virtual DbSet<SkillLevel> SkillLevels { get; set; }
    }
}
