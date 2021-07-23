using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalysis_the_app.DAL.Models
{
   public  class CourseChapter
    {

        [Key]
        public int ChapterId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(200)]
        public string ChapterName { get; set; }
        [DataType(DataType.MultilineText)]
        [StringLength(2000)]
        public string Description { get; set; }
        [Required]

        public int Ordering { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? CreatedTime { get; set; }
        [ForeignKey(nameof(Courses))]
        public int CourseId { get; set; }
        public string DurationDescription { get; set; }

        public virtual Course Courses { get; set; }
        public virtual ICollection<ChapterVideo> ChapterVideos { get; set; }
    }
}
