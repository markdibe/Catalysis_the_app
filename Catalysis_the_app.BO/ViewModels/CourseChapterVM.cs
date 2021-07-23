using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalysis_the_app.BO.ViewModels
{
    public class CourseChapterVM
    {
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
        public int CourseId { get; set; }
        public string DurationDescription { get; set; }
    }
}
