using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Verbos.Model;
using Verbos.Model.Context;

namespace Verbos.Service.Implementation
{
    public class PersonService : IPersonService
    {
        MySqlContext _context;

        public PersonService(MySqlContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return person;
        }

        public Person Update(Person person)
        {
            if (!Exists(person.Id))
                return new Person();

            var result = FindById(person.Id);
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return person;
        }

        public void Delete(long id)
        {
            var result = FindById(id);
            if (result != null)
            {
                _context.Persons.Remove(result);
                _context.SaveChanges();
            }
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindById(long id)
        {
            return _context.Persons.Single(x => x.Id == id); 
        }

        private bool Exists(long id)
        {
            return _context.Persons.Any(x => x.Id == id);
        }
    }
}
