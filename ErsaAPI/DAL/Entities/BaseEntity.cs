using ErsaAPI.Interfaces;

namespace ErsaAPI.DAL.Entities
{
    public class BaseEntity : IEntity
    {
        public int ID { get; set; }
    }
}
