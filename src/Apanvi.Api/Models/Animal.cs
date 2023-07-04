using System.ComponentModel.DataAnnotations.Schema;

namespace Apanvi.API.Models
{
    [Table("animal")]
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Species Species { get; set; }
        public Size Size { get; set; }
        public Age Age { get; set; }
        public Genre Genre { get; set; }
        public String? Description { get; set; }
        public Uri? Image { get; set; }

    }
}
