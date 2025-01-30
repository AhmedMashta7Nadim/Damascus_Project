using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Model_Entity.DTO;
using Model_Entity.Models;
using Model_Entity.VM;

namespace InfraStractur.Data.Mapping_Models
{
    internal class _Mapping: Profile
    {
        public _Mapping()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserSummary>().ReverseMap();
            CreateMap<UserSummary, User>();

            CreateMap<Course, CourseDTO>().ReverseMap();
            CreateMap<Course, CourseSummary>().ReverseMap();

            CreateMap<UserCourse, UserCourseDTO>().ReverseMap();
            CreateMap<UserCourse, UserCourseSummary>().ReverseMap();
        }
    }
}
