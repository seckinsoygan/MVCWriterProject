using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(100)]
        public string CategoryName { get; set; }
        [StringLength(100)]
        public string CategoryDescription { get; set; }
        [StringLength(100)]
        public bool CategoryStatus { get; set; }
        public ICollection<Heading> Headings { get; set; }
    }
}
