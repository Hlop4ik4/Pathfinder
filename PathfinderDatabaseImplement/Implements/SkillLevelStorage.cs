using Microsoft.EntityFrameworkCore;
using PathfinderContracts.Models;
using PathfinderDatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderDatabaseImplement.Implements
{
    public class SkillLevelStorage
    {
        public List<SkillLevelViewModel> GetFullList()
        {
            using var context = new PathfinderDatabase();
            return context.SkillLevels
                .Include(rec => rec.Skill)
                .Select(CreateModel)
                .ToList();
        }

        public SkillLevelViewModel GetElement(int id)
        {
            using var context = new PathfinderDatabase();
            var skillLevel = context.SkillLevels.FirstOrDefault(rec => rec.Id == id);
            return skillLevel != null ? CreateModel(skillLevel) : null;
        }

        public void Insert(SkillLevelViewModel model)
        {
            using var context = new PathfinderDatabase();
            context.SkillLevels.Add(CreateModel(model, new SkillLevel()));
            context.SaveChanges();
        }

        public void Update(SkillLevelViewModel model)
        {
            using var context = new PathfinderDatabase();
            var element = context.SkillLevels.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, element);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PathfinderDatabase();
            SkillLevel element = context.SkillLevels.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.SkillLevels.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        private static SkillLevel CreateModel(SkillLevelViewModel model, SkillLevel skillLevel)
        {
            skillLevel.SkillId = model.SkillId;
            skillLevel.Level = model.Level;
            return skillLevel;
        }

        private static SkillLevelViewModel CreateModel(SkillLevel skillLevel)
        {
            return new SkillLevelViewModel
            {
                Id = skillLevel.Id,
                SkillId = skillLevel.SkillId,
                SkillName = skillLevel.Skill.Name,
                Level = skillLevel.Level
            };
        }
    }
}
