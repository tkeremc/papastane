using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestorantAmaCiddili.Models
{
    public class Food
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Photo { get; set; }
        public double Price { get; set; }
        public bool Activeness { get; set; }
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Categories Category { get; set; }
    }
}
