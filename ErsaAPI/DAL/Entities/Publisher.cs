using ErsaAPI.Interfaces;

namespace ErsaAPI.DAL.Entities
{
    public class Publisher : BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
