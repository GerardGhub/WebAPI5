using System.Collections;
using System.Collections.Generic;
using WebAPI5.Models;

namespace WebAPI5.Contracts
{
    public interface IHeroRepository: IBaseRepository<Hero>
    {
        IEnumerable<Hero> GetByAge(int age);
    }
}
