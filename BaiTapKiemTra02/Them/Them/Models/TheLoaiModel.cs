using System.ComponentModel.DataAnnotations;

namespace Them.Models
{
    public class TheLoaiModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
