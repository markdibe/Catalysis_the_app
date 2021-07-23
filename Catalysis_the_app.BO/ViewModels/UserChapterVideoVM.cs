using Catalysis_the_app.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalysis_the_app.BO.ViewModels
{
    public class UserChapterVideoVM
    {
        public int UserChapterVideoId { get; set; }


        [StringLength(450)]
        public string UserId { get; set; }
        public ApplicationUser user { get; set; }


        public int VideoId { get; set; }

        [Required]
        public bool IsFullyWatched { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime LastTimeWatched { get; set; }

    }
}
