using WebAPI5.Contracts;
using WebAPI5.Models;

namespace WebAPI5.Repositories
{
    public class PositionRepository : BaseRepository<Position>, IPositionRepository
    {
        public PositionRepository() : base() { }
    }
}
