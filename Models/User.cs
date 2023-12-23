using WebAPI5.Contracts;

namespace WebAPI5.Models
{
    public class User:IBaseModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
