using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Entity.Models
{
    public class UserCourse:Entity_ID
    {
        public DateTime dateTime { get; set; } = DateTime.UtcNow;
        public Guid CourseId { get; set; }
        public Guid UserId { get; set; }
    }
}
