using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalysis_the_app.DAL.Models
{
    public class UserChapterVideo
    {

        [Key]
        public int UserChapterVideoId { get; set; }

        [ForeignKey(nameof(user))]
        [StringLength(450)]
        public string UserId { get; set; }
        public ApplicationUser user { get; set; }

        [ForeignKey(nameof(ChapterVideo))]
        public int VideoId { get; set; }
        public ChapterVideo ChapterVideo { get; set; }
        [Required]
        public bool IsFullyWatched { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime LastTimeWatched { get; set; }

    }
}
