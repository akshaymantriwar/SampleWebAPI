using System.Linq;

namespace DAL
{
    public class PersonDao
    {
        private readonly MYDBEntities mYDBEntities = new MYDBEntities();

        public IQueryable<Person> GetAll()
        {
            return mYDBEntities.People.Where(x => x.Id > 0);
        }
    }
}
