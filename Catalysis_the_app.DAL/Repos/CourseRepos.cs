using Catalysis_the_app.DAL.Models;
using Catalysis_the_app.DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalysis_the_app.DAL.Repos
{
    public class CourseRepos : GenericRepos<Course>,ICourseRepos
    {
        public CourseRepos(ApplicationDbContext context) : base(context)
        {
        }
    }
}
