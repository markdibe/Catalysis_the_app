using Catalysis_the_app.DAL.Models;
using Catalysis_the_app.DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalysis_the_app.DAL
{
    public interface IUnitOfWork
    {

        ICategoryRepos CategoryRepos { get; }
        ICourseRepos CourseRepos { get; }
        ICourseImagesRepos CourseImagesRepos{ get; }
        ICourseChapterRepos CourseChapter { get; }
        IChapterVideoRepos ChapterVideoRepos { get; }
        IVideoCommentsRepos VideoCommentsRepos { get; }
        IUserChapterVideoRepos UserChapterVideoRepos { get; }
        IUserCourseRepos UserCourseRepos { get; }
    }
}
