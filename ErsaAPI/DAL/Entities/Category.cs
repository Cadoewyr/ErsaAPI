using ErsaAPI.Interfaces;

namespace ErsaAPI.DAL.Entities
{
    public class Category : BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
