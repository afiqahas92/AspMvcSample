using System.ComponentModel.DataAnnotations;

namespace VodusAssesmentMVC.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        //description can be null
        public string? Description { get; set; }
        public double Price { get; set; }
    }
}
