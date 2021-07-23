using AutoMapper;
using Catalysis_the_app.BO;
using Catalysis_the_app.BO.IServices;
using Catalysis_the_app.BO.Services;
using Catalysis_the_app.BO.ViewModels;
using Catalysis_the_app.DAL;
using Catalysis_the_app.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalysis_the_app.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        //private readonly IBaseService<CategoryVM, Category> _cat;

        private readonly BaseFilterBO<Category> _filter;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unit;


        public CategoriesController(BaseFilterBO<Category> filter, IMapper mapper, IUnitOfWork unit)
        {
            _filter = filter;
            _mapper = mapper;
            _unit = unit;
        }

        private Category Convert(CategoryVM categoryVM)
        {
            return _mapper.Map<Category>(categoryVM);
        }

        private CategoryVM Convert(Category category)
        {
            return _mapper.Map<CategoryVM>(category);
        }


        private async Task AddCategories()
        {
            for (int i = 0; i < 30; i++)
            {
                await _unit.CategoryRepos.Create(new Category { ImageUrl = "/images/noitnull.jpg", CategoryName = $"Category name {i}", Description = "Description", DateCreated = DateTime.Now });
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryVM>>> Get([FromQuery] QueryFilter query)
        {
            var db_category = _filter.Filter(query);
            IEnumerable<CategoryVM> categories = await Task.Run(() => (from cat in db_category select _mapper.Map<CategoryVM>(cat)));
            return Ok(categories);
        }


        [HttpPost]
        public async Task<ActionResult<CategoryVM>> Add([FromForm] CategoryVM category)
        {
            if (category.FormFile != null)
            {
                category.ImageUrl = await category.FormFile.SaveImage("Categories");
            }
            Category cat = Convert(category);
            await _unit.CategoryRepos.Create(cat);
            CategoryVM result = Convert(cat);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<CategoryVM>> Update([FromForm] CategoryVM category)
        {

            if (category.FormFile != null)
            {
                category.ImageUrl = await category.FormFile.SaveImage("Categories");
            }
            Category cat = Convert(category);
            await _unit.CategoryRepos.Update(cat);
            CategoryVM result = Convert(cat);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            await _unit.CategoryRepos.Delete(id);
            return Ok();
        }


    }
}
