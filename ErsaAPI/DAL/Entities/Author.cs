using ErsaAPI.Interfaces;

namespace ErsaAPI.DAL.Entities
{
    public class Author : BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
