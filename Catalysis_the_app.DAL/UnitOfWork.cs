using Catalysis_the_app.DAL.Repos;
using Catalysis_the_app.DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Catalysis_the_app.DAL
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {

        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        #region private

        private ICategoryRepos categoryRepos;

        private ICourseRepos courseRepos;

        private ICourseImagesRepos courseImagesRepos;

        private ICourseChapterRepos courseChapter;

        private IChapterVideoRepos chapterVideoRepos;

        private IVideoCommentsRepos videoCommentsRepos;

        private IUserChapterVideoRepos userChapterVideoRepos;

        private IUserCourseRepos userCourseRepos;
        #endregion

        #region public
        #endregion
        public ICategoryRepos CategoryRepos => categoryRepos ?? new CategoryRepos(_context);

        public ICourseRepos CourseRepos => courseRepos ?? new CourseRepos(_context);

        public ICourseImagesRepos CourseImagesRepos => courseImagesRepos ?? new CourseImagesRepos(_context);

        public ICourseChapterRepos CourseChapter => courseChapter ?? new CourseChapterRepos(_context);

        public IChapterVideoRepos ChapterVideoRepos => chapterVideoRepos ?? new ChapterVideoRepos(_context);

        public IVideoCommentsRepos VideoCommentsRepos => videoCommentsRepos ?? new VideoCommentsRepos(_context);


        public IUserCourseRepos UserCourseRepos => userCourseRepos ?? new UserCourseRepos(_context);

        public IUserChapterVideoRepos UserChapterVideoRepos => userChapterVideoRepos ?? new UserChapterVideosRepos(_context);

        

        public void Dispose()
        {
            _context.Dispose();

        }
    }
}
