using System.Collections;
using System.Collections.Generic;
using WebAPI5.Models;

namespace WebAPI5.Contracts
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetOne(int id);
        void Add(User user);
        void Update(User user);
        void Delete(int id);
    }
}
