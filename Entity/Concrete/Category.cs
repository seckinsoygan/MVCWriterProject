using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(100)]
        public string CategoryName { get; set; }
        [StringLength(1000)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }
        public ICollection<Heading> Headings { get; set; }
    }
}
