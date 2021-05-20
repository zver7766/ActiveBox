using System.ComponentModel.DataAnnotations;

namespace ActiveBox.Domain.Entities
{
    public class Type
    {
        [Required]
        public int Id { get; set; }
        public string NameOfType { get; set; }
    }
}