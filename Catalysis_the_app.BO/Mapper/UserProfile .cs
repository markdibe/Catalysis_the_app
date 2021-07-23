using AutoMapper;
using Catalysis_the_app.BO.ViewModels;
using Catalysis_the_app.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalysis_the_app.BO.Mapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Category, CategoryVM>().ReverseMap();
        }
    }
}
