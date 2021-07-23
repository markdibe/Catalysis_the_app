using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalysis_the_app.DAL.Models
{
    public class VideoComments
    {

        [Key]
        public int VideoCommentId { get; set; }
        [Required]
        [StringLength(3000)]
        [DataType(DataType.MultilineText)]
        public string Comment { get; set; }
        [ForeignKey(nameof(user))]
        public string CommentedBy { get; set; }
        public ApplicationUser user { get; set; }

        public bool Approved { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ConfirmationDate { get; set; }
        public string ApprovedBy { get; set; }

        [ForeignKey(nameof(ChapterVideo))]
        public int ChapterVideoId { get; set; }

        public virtual ChapterVideo ChapterVideo { get; set; }
    }
}
