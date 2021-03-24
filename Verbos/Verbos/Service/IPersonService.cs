using System.Collections.Generic;
using Verbos.Model;

namespace Verbos.Service
{
    public interface IPersonService
    {
        Person Create(Person person);

        Person Update(Person person);

        void Delete(long id);

        Person FindById(long id);

        List<Person> FindAll();
    }
}
