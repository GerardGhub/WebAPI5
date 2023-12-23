using WebAPI5.Contracts;

namespace WebAPI5.Models
{
    public class Hero: IBaseModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
