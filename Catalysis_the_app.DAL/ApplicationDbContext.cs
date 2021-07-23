using Catalysis_the_app.DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Catalysis_the_app.DAL
{
    public class ApplicationDbContext : IdentityDbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Course> courses { get; set; }
        public virtual DbSet<CourseImages> courseImages { get; set; }
        public virtual DbSet<CourseChapter> courseChapters { get; set; }
        public virtual DbSet<ChapterVideo> chapterVideos { get; set; }

        public virtual DbSet<VideoComments> videoComments { get; set; }
        public virtual DbSet<UserCourse> userCourses { get; set; }
        public virtual DbSet<UserChapterVideo> userChapterVideos { get; set; }




    }
}
    

