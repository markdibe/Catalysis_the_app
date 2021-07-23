using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalysis_the_app.DAL.Models
{
   public  class Course
    {

        [Key]
        public int CourseId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(200)]
        public string CourseName { get; set; }
        [DataType(DataType.MultilineText)]
        [StringLength(2000)]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(200)]
        public string Title { get; set; }
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        [DataType(DataType.Text)]
        [StringLength(200)]
        public int Rate { get; set; }

        public float CoursePrice { get; set; }
        public string Unit { get; set; }


        public virtual Category Category { get; set; }
        public virtual ICollection<CourseChapter> CourseChapters { get; set; }
        public virtual ICollection<CourseImages> CourseImages { get; set; }
        public virtual ICollection<UserCourse> UserCourses { get; set; }

    }
}
