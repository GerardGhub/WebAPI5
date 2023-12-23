using System.Collections.Generic;
using System.Linq;
using WebAPI5.Contracts;
using WebAPI5.Infrastructure;

namespace WebAPI5.Repositories
{

    public class BaseRepository<T>: IBaseRepository<T> where T : IBaseModel
    {
        private readonly FakeDbContext _db = new FakeDbContext();
        private readonly List<T> _table;

        public BaseRepository() {
        _table = _db.GetTable<T>();
        }

        public void Add(T model)
        {
            model.Id = _table.Count + 1;
            _table.Add(model);
        }

        public void Delete(int id)
        {
            _table.RemoveAll(u => u.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _table;
        }

        public T GetOne(int id)
        {
            return _table.FirstOrDefault(u => u.Id == id);
        }

        public void Update(T model)
        {
            var index = _table.FindIndex(u => u.Id == model.Id);
            _table[index] = model;
        }
    }
}
