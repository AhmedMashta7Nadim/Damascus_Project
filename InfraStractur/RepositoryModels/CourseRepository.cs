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
    public class CourseRepository : ServisesRepository<Course, CourseSummary>
    {
        public CourseRepository(ConnectionDataBase context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
