using Catalysis_the_app.BO.IServices;
using Catalysis_the_app.BO.Services;
using Catalysis_the_app.BO.ViewModels;
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
        private readonly IBaseService<CategoryVM, Category> _cat;
        public CategoriesController(IBaseService<CategoryVM,Category> cat)
        {
            _cat = cat;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryVM>>> Get([FromQuery] QueryFilter query)
        {
            return Ok(await _cat.Get(query));
        }


    }
}
