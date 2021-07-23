using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalysis_the_app.BO.ViewModels
{
   public  class ChapterVideoVM
    {
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
        
        public int ChapterId { get; set; }
        
        [Required]
        [DataType(DataType.ImageUrl)]
        [StringLength(2000)]
        public string VideoUrl { get; set; }
        public int Ordering { get; set; }
        public bool CanComment { get; set; }
        public int NumberOfLikes { get; set; }
        public int NumberOfDislike { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
