using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalysis_the_app.BO.ViewModels
{
    public class UserCourseVM
    {
        public string UserId { get; set; }

        public int CourseId { get; set; }

        public int UserCourseId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime JoiningTime { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime LastSee { get; set; }

        public int ChapterVideoId { get; set; }
        public TimeSpan DurationStopped { get; set; }
    }
}
