using Authentication.auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Damascus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ITokenService tokenService;

        public AuthController(ITokenService TokenService)
        {
            tokenService = TokenService;
        }

        //[HttpPost]
        //public async Task<string> getToken()
        //{
        //  var x= tokenService.GenerateToken(new Model_Entity.Models.User());
        //    return x;
        //}
    }
}
