using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using InfraStractur.Data;
using InfraStractur.Repository;
using Model_Entity.Models;
using Model_Entity.VM;

namespace InfraStractur.RepositoryModels
{
    public class UserCourseRepository: ServisesRepository<UserCourse, UserCourseSummary>
    {
        private readonly ConnectionDataBase context;

        public UserCourseRepository(ConnectionDataBase context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
