using System.ComponentModel.DataAnnotations;

namespace Shopping_Site.Models
{
    public enum SortOrder { Ascending=0, Descending=1 }
    public class Unit
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }

    }
}
