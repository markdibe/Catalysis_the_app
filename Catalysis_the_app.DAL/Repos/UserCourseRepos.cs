using Catalysis_the_app.DAL.Models;
using Catalysis_the_app.DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalysis_the_app.DAL.Repos
{
    public class UserCourseRepos : GenericRepos<UserCourse>,IUserCourseRepos
    {
        public UserCourseRepos(ApplicationDbContext context) : base(context)
        {
        }
    }
}
