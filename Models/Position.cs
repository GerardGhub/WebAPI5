using WebAPI5.Contracts;

namespace WebAPI5.Models
{
    public class Position:IBaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
