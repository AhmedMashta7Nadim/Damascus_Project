using AutoMapper;
using InfraStractur.RepositoryModels;
using Microsoft.AspNetCore.Mvc;
using Model_Entity.DTO;
using Model_Entity.Models;
using Model_Entity.VM;

namespace Damascus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCourseController : ControllerBase
    {
        private readonly UserCourseRepository repository;
        private readonly IMapper mapper;

        public UserCourseController(UserCourseRepository repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }


        [HttpPost("AddUserCourse")]
        public async Task<ActionResult<UserCourse>> AddUserCourseAsync(UserCourseDTO user)
        {
            var mapping=mapper.Map<UserCourse>(user);
            var request = await repository.Add(mapping);
            if (request == null)
            {
                return BadRequest(" null ");
            }
            return Ok(request);
        }

        [HttpGet("UserCourses")]
        public async Task<ActionResult<List<UserCourse>>> GetAllUserCoursesAsync()
        {
            var getAll=await repository.GetAllAsync();
            if(getAll is null)
            {
                return NotFound(" null ");
            }
            return Ok(getAll);
        }




















        [HttpDelete("RemoveUserCourses")]
        public async Task<ActionResult<UserCourse>> RemoveUserCourses(Guid Id)
        {
            var deleted=await repository.SoftDeletedAsync(Id);
            if(deleted == null)
            {
                return NotFound( " null " );
            }
            return NoContent();
        }

    }
}
