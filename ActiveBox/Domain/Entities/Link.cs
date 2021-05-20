namespace ActiveBox.Domain.Entities
{
    public class Link
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EntityBaseId { get; set; }
        public EntityBase EntityBases { get; set; }
        public string Links { get; set; }
    }
}