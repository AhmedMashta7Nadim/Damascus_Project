using AutoMapper;
using InfraStractur.RepositoryModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model_Entity.DTO;
using Model_Entity.Models;
using Model_Entity.VM;

namespace Damascus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly CourseRepository courseRepository;
        private readonly IMapper mapper;

        public CourseController(
            CourseRepository courseRepository,
            IMapper mapper
            )
        {
            this.courseRepository = courseRepository;
            this.mapper = mapper;
        }

        //[Authorize(Roles = "Teacher,Admin")]
        [HttpPost("Add-Courses")]
        public async Task<ActionResult<Course>> AddCourseAsync(CourseDTO course)
        {
            var mapping=mapper.Map<Course>(course);
            var request = await courseRepository.Add(mapping);

            return Ok(request);
        }

        [HttpGet("getAllCourses")]
        public async Task<ActionResult<List<CourseSummary>>> getCoursesAsync()
        {
            var getAll = await courseRepository.GetAllAsync();
            return Ok(getAll);
        }

        [HttpGet("GetCourseAsync")]
        public async Task<ActionResult<object>> GetCourseAsync(Guid id)
        {
            var get = await courseRepository.GetAsync(id, true, x => x.Include(u=>u.users));
            if (get is null)
            {
                return NotFound();
            }
            return Ok(get);
        }
    }
}
