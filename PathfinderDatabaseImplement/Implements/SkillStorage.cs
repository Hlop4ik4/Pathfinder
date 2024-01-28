using PathfinderContracts.Models;
using PathfinderDatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderDatabaseImplement.Implements
{
    public class SkillStorage
    {
        public List<SkillViewModel> GetFullList()
        {
            using var context = new PathfinderDatabase();
            return context.Skills
            .Select(CreateModel)
            .ToList();
        }

        public SkillViewModel GetElement(int id)
        {
            using var context = new PathfinderDatabase();
            var skill = context.Skills.FirstOrDefault(rec => rec.Id == id);
            return skill != null ? CreateModel(skill) : null;
        }

        public void Insert(SkillViewModel model)
        {
            using var context = new PathfinderDatabase();
            context.Skills.Add(CreateModel(model, new Skill()));
            context.SaveChanges();
        }

        public void Update(SkillViewModel model)
        {
            using var context = new PathfinderDatabase();
            var element = context.Skills.FirstOrDefault(rec => rec.Id == model.Id);
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
            Skill element = context.Skills.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Skills.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        private static Skill CreateModel(SkillViewModel model, Skill skill)
        {
            skill.Name = model.Name;
            return skill;
        }

        private static SkillViewModel CreateModel(Skill skill)
        {
            return new SkillViewModel
            {
                Id = skill.Id,
                Name = skill.Name
            };
        }
    }
}
