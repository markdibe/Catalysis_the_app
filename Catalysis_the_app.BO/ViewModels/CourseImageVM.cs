using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalysis_the_app.BO.ViewModels
{
    class CourseImageVM
    {
        public int CourseImageId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(200)]
        public string CourseImageName { get; set; }

        [DataType(DataType.ImageUrl)]
        [StringLength(200)]
        public string ImageUrl { get; set; }
        public int CourseId { get; set; }

        public IFormFile FormFile { get; set; }

    }
}
