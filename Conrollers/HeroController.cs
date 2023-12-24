using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI5.Contracts;
using WebAPI5.Models;

namespace WebAPI5.Conrollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : BaseController<Hero>
    {
        private readonly IHeroRepository _repository;
        public HeroController(IHeroRepository repository) : base(repository)
        {
            _repository = repository;
        }

        [HttpGet("ByAge/{age}")]
        public IActionResult GetByAge(int age)
        {
            return Ok(_repository.GetByAge(age));
        }
    }
}
