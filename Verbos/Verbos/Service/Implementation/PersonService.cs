using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Verbos.Model;

namespace Verbos.Service.Implementation
{
    public class PersonService : IPersonService
    {
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
            throw new NotImplementedException();
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
