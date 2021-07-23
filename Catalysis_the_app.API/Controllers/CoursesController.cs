using AutoMapper;
using Catalysis_the_app.BO;
using Catalysis_the_app.BO.ViewModels;
using Catalysis_the_app.DAL;
using Catalysis_the_app.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Catalysis_the_app.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly IUnitOfWork _unit;
        private readonly IMapper _mapper;
        private readonly BaseFilterBO<Course> _courses;

        public CoursesController(IUnitOfWork unit, IMapper mapper, BaseFilterBO<Course> courses)
        {
            _unit = unit;
            _mapper = mapper;
            _courses = courses;
        }

        private CourseVM Convert(Course course)
        {
            return _mapper.Map<CourseVM>(course);
        }

        private Course Convert(CourseVM course)
        {
            return _mapper.Map<Course>(course);
        }


        [HttpGet]
        public ActionResult<IEnumerable<CourseVM>> Get([FromQuery] QueryFilter query)
        {
            IEnumerable<Course> courses = _courses.Filter(query);
            IEnumerable<CourseVM> courseVMs = (from course in courses select Convert(course));
            return Ok(courseVMs);
        }

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public async Task<CourseVM> Get(int id)
        {
            return Convert(await _unit.CourseRepos.GetById(id));
        }

        // POST api/<CoursesController>
        [HttpPost]
        public async Task<CourseVM> Post([FromForm] CourseVM course)
        {
            Course resultCourse = await _unit.CourseRepos.Create(Convert(course));
            if (course.FormFiles != null)
            {
                foreach (var file in course.FormFiles)
                {
                    string imageUrl = await file.SaveImage("Courses");
                    CourseImages courseImages = new CourseImages { CourseId = resultCourse.CourseId, CourseImageName = file.FileName, ImageUrl = imageUrl };
                    await _unit.CourseImagesRepos.Create(courseImages);
                }
            }
            return Convert(resultCourse);
        }

        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public async Task<CourseVM> Put(int id, [FromBody] CourseVM course)
        {
            Course resultCourse = Convert(course);
            await _unit.CourseRepos.Update(resultCourse);
            if (course.FormFiles != null)
            {
                foreach (var file in course.FormFiles)
                {
                    string imageUrl = await file.SaveImage("Courses");
                    CourseImages courseImages = new CourseImages { CourseId = resultCourse.CourseId, CourseImageName = file.FileName, ImageUrl = imageUrl };
                    await _unit.CourseImagesRepos.Create(courseImages);
                }
            }
            return Convert(resultCourse);
        }

        // DELETE api/<CoursesController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _unit.CourseRepos.Delete(id);
        }
    }
}
