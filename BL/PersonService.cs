using System.Collections.Generic;
using System.Linq;
using DAL;

namespace BL
{
    public class PersonService
    {
        private readonly PersonDao personDao = new PersonDao();

        public List<Person> GetAll()
        {
            return personDao.GetAll().ToList();
        }
    }
}
