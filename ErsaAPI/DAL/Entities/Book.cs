using ErsaAPI.Interfaces;

namespace ErsaAPI.DAL.Entities
{
    public class Book : BaseEntity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Author { get; set; }
        public int Publisher { get; set; }
        public string ISBN { get; set; }
        public int Category { get; set; }
    }
}
