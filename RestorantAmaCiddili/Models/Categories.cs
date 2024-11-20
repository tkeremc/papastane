using System.ComponentModel.DataAnnotations;

namespace RestorantAmaCiddili.Models
{
    public class Categories
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string CategoryName { get; set; }
    }
}
