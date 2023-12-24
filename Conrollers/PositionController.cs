using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI5.Contracts;
using WebAPI5.Models;

namespace WebAPI5.Conrollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : BaseController<Position>
    {
        public PositionController(IBaseRepository<Position> repository) : base(repository)
        {
        }
    }
}
