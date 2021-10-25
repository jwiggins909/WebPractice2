using System.Collections.Generic;
using WebPractice;

namespace api.interfaces
{
    public interface IPersonDataHandler
    {
         public List<Person> Select();
         public void Delete(Person person);
         public void Insert(Person person);
         public void Update(Person person);
    }
}