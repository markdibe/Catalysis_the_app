using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalysis_the_app.DAL.Models
{
   public class Category
    {

        [Key]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(200)]
        [DataType(DataType.Text)]
        public string CategoryName { get; set; }
        [StringLength(2000)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required]
        [StringLength(500)]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }
        


        public virtual ICollection<Course> Courses { get; set; }
    }
}
