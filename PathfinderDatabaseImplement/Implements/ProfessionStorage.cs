using PathfinderContracts.Models;
using PathfinderDatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderDatabaseImplement.Implements
{
    public class ProfessionStorage
    {
        public List<ProfessionViewModel> GetFullList()
        {
            using var context = new PathfinderDatabase();
            return context.Professions
            .Select(CreateModel)
            .ToList();
        }

        public ProfessionViewModel GetElement(int id)
        {
            using var context = new PathfinderDatabase();
            var profession = context.Professions.FirstOrDefault(rec => rec.Id == id);
            return profession != null ? CreateModel(profession) : null;
        }

        public void Insert(ProfessionViewModel model)
        {
            using var context = new PathfinderDatabase();
            context.Professions.Add(CreateModel(model, new Profession()));
            context.SaveChanges();
        }

        public void Update(ProfessionViewModel model)
        {
            using var context = new PathfinderDatabase();
            var element = context.Professions.FirstOrDefault(rec => rec.Id == model.Id);
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
            Profession element = context.Professions.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Professions.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        private static Profession CreateModel(ProfessionViewModel model, Profession profession)
        {
            profession.Name = model.Name;
            return profession;
        }

        private static ProfessionViewModel CreateModel(Profession profession)
        {
            return new ProfessionViewModel
            {
                Id = profession.Id,
                Name = profession.Name
            };
        }
    }
}
