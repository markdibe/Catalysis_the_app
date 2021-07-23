using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalysis_the_app.DAL.Models
{
 public class CourseImages
    {
        [Key]
        public int CourseImageId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(200)]
        public string CourseImageName { get; set; }

        [DataType(DataType.ImageUrl)]
        [StringLength(200)]
        public string ImageUrl { get; set; }
        [ForeignKey(nameof(Models.Course))]
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }


    }
}
