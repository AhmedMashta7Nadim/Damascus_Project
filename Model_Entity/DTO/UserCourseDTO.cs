using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Entity.DTO
{
    public class UserCourseDTO
    {
        public Guid CourseId { get; set; }
        public Guid UserId { get; set; }
    }
}
