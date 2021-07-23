using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalysis_the_app.DAL.Models
{
  public  class ChapterVideo
    {

        [Key]
        public int ChapterVideoId { get; set; }
        [Required]
        [StringLength(200)]
        [DataType(DataType.Text)]
        public string ChapterVideoName { get; set; }
        [StringLength(2000)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [StringLength(2000)]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
        [Required]
        [ForeignKey(nameof(courseChapters))]
        public int ChapterId { get; set; }
        public CourseChapter courseChapters { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        [StringLength(2000)]
        public string VideoUrl { get; set; }
        public int Ordering { get; set; }
        public bool CanComment { get; set; }
        public int NumberOfLikes { get; set; }
        public int NumberOfDislike { get; set; }
        public TimeSpan Duration { get; set; }

        public virtual ICollection<UserChapterVideo> UserChapterVideos { get; set; }
        public virtual ICollection<UserCourse> UserCourses { get; set; }
        public virtual ICollection<VideoComments> VideoComments { get; set; }
    }
}
