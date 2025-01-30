using Authentication.auth;
using AutoMapper;
using InfraStractur.Data;
using InfraStractur.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Model_Entity.DTO;
using Model_Entity.Models;
using Model_Entity.VM;

namespace InfraStractur.RepositoryModels
{
    public class UserRepository : ServisesRepository<User, UserSummary>
    {
        private readonly ConnectionDataBase context;
        private readonly ITokenService token;
        private readonly IMapper mapper;

        public UserRepository(ConnectionDataBase context, IMapper mapper, ITokenService token) : base(context, mapper)
        {
            this.context = context;
            this.token = token;
            this.mapper = mapper;
        }
       
        public async Task<string> ResultToken(UserSigning signing)
        {
            try
            {
                var Exist = await context.users
              .FirstOrDefaultAsync(x => x.Password.ToString() == signing.Password.ToString()
              &&
              x.Email==signing.Email
              );
                if (Exist is null)
                {
                    return null;
                }
                return token.GenerateToken(Exist);

            }
            catch (Exception expp)
            {
                return expp.ToString();
            }
        }
      
        public async Task<List<Course>> getAllCourse(Guid Id)
        {
            var selected=await context.users.FirstOrDefaultAsync(x => x.Id == Id);
            if (selected is null)
            {
                return null;
            }
              return selected.courses;
        }











    }
}
