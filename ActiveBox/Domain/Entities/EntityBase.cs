using System.ComponentModel.DataAnnotations;

namespace ActiveBox.Domain.Entities
{
    public class EntityBase
    {
        [Required]
        public int Id { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }
        public int TypeId { get; set; }
        
        public Type Type { get; set; }
    }
}