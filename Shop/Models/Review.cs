namespace Shop.Models
{
    public class Review : IEntity
    {
        public string Comment { get; set; }
        public virtual Product Product { get; set; }
    }
}