using System.Collections.Generic;
using System.Linq;
using WebAPI5.Contracts;
using WebAPI5.Infrastructure;
using WebAPI5.Models;

namespace WebAPI5.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly FakeDbContext _db = new FakeDbContext();
        public void Add(User user)
        {
            user.Id = _db.Users.Count + 1;
            _db.Users.Add(user);
        }

        public void Delete(int id)
        {
            _db.Users.RemoveAll(u => u.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _db.Users;
        }

        public User GetOne(int id)
        {
           return _db.Users.FirstOrDefault(u => u.Id == id);
        }

        public void Update(User user)
        {
            var index = _db.Users.FindIndex(u => u.Id == user.Id);
            _db.Users[index] = user;
        }
    }
}
