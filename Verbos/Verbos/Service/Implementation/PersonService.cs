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
            return person;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindById(long id)
        {
            throw new NotImplementedException();
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
