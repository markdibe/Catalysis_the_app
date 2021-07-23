using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalysis_the_app.BO.ViewModels
{
    public class VideoCommentVM
    {
        public int VideoCommentId { get; set; }
        [Required]
        [StringLength(3000)]
        [DataType(DataType.MultilineText)]
        public string Comment { get; set; }

        public string CommentedBy { get; set; }


        public bool Approved { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ConfirmationDate { get; set; }
        public string ApprovedBy { get; set; }
        public int ChapterVideoId { get; set; }
    }
}
