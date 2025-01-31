using Authentication.auth;
using AutoMapper;
using InfraStractur.RepositoryModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Model_Entity.DTO;
using Model_Entity.Models;
using Model_Entity.VM;

namespace Damascus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository repository;
        private readonly ITokenService tokenService;
        private readonly IMapper mapper;

        public UserController(
            UserRepository repository,
            ITokenService tokenService,
            IMapper mapper
            )
        {
            this.repository = repository;
            this.tokenService = tokenService;
            this.mapper = mapper;
        }

        [HttpPost("resultToken")]
        public async Task<ActionResult<string>> resultToken([FromBody]UserSigning user)
        {
            var result=await repository.ResultToken(user);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
        [HttpPost("AddUser")]
        public async Task<ActionResult<UserSummary>> AddUser([FromForm] UserDTO user)
        {
            var mappedUser = mapper.Map<User>(user);
            var addUser = await repository.Add(mappedUser);
            return Ok(addUser);
        }

        [HttpGet("getAllUser")]
        public async Task<ActionResult<List<UserSummary>>> getUserAsync()
        {
            var getAll=await repository.GetAllAsync();
            return Ok(getAll);
        }

        [HttpGet("GetUserAsync")]
        public async Task<ActionResult<object>> GetUserAsync(Guid id)
        {
            var get = await repository.GetAsync(id,true,x=>x.Include(c=>c.courses));
            if (get is null)
            {
                return NotFound();
            }
            return Ok(get);
        }

        [HttpDelete("Deleted_User")]
        public async Task<ActionResult<string>> DeletedUserAsync(Guid Id)
        {
            var findDeleted=await repository.SoftDeletedAsync(Id);
            if(findDeleted == null)
            {
                return BadRequest(" Id Is Not Users");
            }
            
            return Ok("Succses Deleted");
        }

    }
}
