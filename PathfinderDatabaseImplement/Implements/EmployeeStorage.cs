using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathfinderContracts.Models;
using PathfinderDatabaseImplement.Models;

namespace PathfinderDatabaseImplement.Implements
{
    public class EmployeeStorage
    {
        public List<EmployeeViewModel> GetFullList()
        {
            using var context = new PathfinderDatabase();
            return context.Employees
            .Select(CreateModel)
            .ToList();
        }

        public EmployeeViewModel GetElement(int id)
        {
            using var context = new PathfinderDatabase();
            var employee = context.Employees.FirstOrDefault(rec => rec.Id == id);
            return employee != null ? CreateModel(employee) : null;
        }

        public void Insert(EmployeeViewModel model)
        {
            using var context = new PathfinderDatabase();
            context.Employees.Add(CreateModel(model, new Employee()));
            context.SaveChanges();
        }

        public void Update(EmployeeViewModel model)
        {
            using var context = new PathfinderDatabase();
            var element = context.Employees.FirstOrDefault(rec => rec.Id == model.Id);
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
            Employee element = context.Employees.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Employees.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        private static Employee CreateModel(EmployeeViewModel model, Employee employee)
        {
            employee.FullName = model.FullName;
            return employee;
        }

        private static EmployeeViewModel CreateModel(Employee employee)
        {
            return new EmployeeViewModel
            {
                Id = employee.Id,
                FullName = employee.FullName
            };
        }
    }
}
