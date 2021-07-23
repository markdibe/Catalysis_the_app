using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalysis_the_app.DAL.Models
{
  public class UserCourse
    {
        
        public string UserId { get; set; }
        
        [ForeignKey(nameof(Course))]

        public int CourseId { get; set; }

        [Key]
        public int UserCourseId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime JoiningTime { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime LastSee { get; set; }
        [ForeignKey(nameof(ChapterVideo))]
        public int ChapterVideoId { get; set; }
        public TimeSpan DurationStopped { get; set; }

        public virtual ChapterVideo ChapterVideo { get; set; }
        public virtual Course Course { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
