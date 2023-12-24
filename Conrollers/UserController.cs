using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI5.Contracts;
using WebAPI5.Models;

namespace WebAPI5.Conrollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController<User>
    {
        private readonly IBaseRepository<User> _repository;

        public UserController(IBaseRepository<User> repository) : base(repository) { }

        //public UserController(IBaseRepository<User> userRepository)
        //{
        //    _userRepository = userRepository;
        //}

        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    return Ok(_userRepository.GetAll());
        //}

        //[HttpGet("{id}")]
        //public IActionResult GetOne(int id)
        //{
        //    var user = _userRepository.GetOne(id);
        //    if (user == null)

        //        return NotFound();

        //    return Ok(user);

        //}

        //[HttpPost]
        //public IActionResult Create([FromBody] User user)
        //{
        //    _userRepository.Add(user);
        //    return Ok();
        //}

        //[HttpPut]
        //public IActionResult Update([FromBody] User user) {
        //    _userRepository.Update(user);

        //    return Ok();
        //}


        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    _userRepository.Delete(id);
        //    return Ok();
        //}

        //public IActionResult GetNames()
        //{
        //    var names = new[]
        //    {
        //        new { Name ="frace", Address = "PH"},
        //        new {Name ="Gerard", Address="PH"}
        //    };
        //    return Ok(names);
        //}

    }
}
