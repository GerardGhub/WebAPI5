using System.Collections.Generic;
using System.Linq;
using WebAPI5.Contracts;
using WebAPI5.Models;

namespace WebAPI5.Repositories
{
    public class HeroRepository : BaseRepository<Hero>, IHeroRepository
    {
        public HeroRepository() :base()
        {
        }

        public IEnumerable<Hero> GetByAge(int age)
        {
            return _table.Where(t => t.Age == age);
        }
    }
}
