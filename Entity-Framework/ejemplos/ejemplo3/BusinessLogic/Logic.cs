using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Logic
    {
        public void AddPerson(string name, int age)
        {
            using (var context = new MyContext())
            {
                Person personToAdd = new Person() { Name = name, Age = age };
                // context.MyPersons.Add(personToAdd);
                context.Entry(personToAdd).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<Person> GetPeople()
        {
            using (var context = new MyContext())
            {
                return context.MyPersons.ToList<Person>();
            }
        }

        public void DeletePerson(Person person)
        {
            using (var context = new MyContext())
            {
                // Person personToDelete = context.MyPersons.Find(person.Id);
                // context.MyPersons.Remove(personToDelete);
                context.Entry(person).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void EditPersonName(Person person, string name)
        {
            using (var context = new MyContext())
            {
                person.Name = name;
                context.Entry(person).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<Person> FindByAge(int age)
        {
            using (var context = new MyContext())
            {
                List<Person> list = (from person in context.MyPersons
                                     where person.Age == age
                                     select person).ToList<Person>();
                return list;
            }
        }
    }
}
