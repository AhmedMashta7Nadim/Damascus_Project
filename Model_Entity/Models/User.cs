using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model_Entity.Enum_Class;

namespace Model_Entity.Models
{
    public class User:Entity_ID
    {
        public required string Name { get; set; }
        [EmailAddress]
        public required string Email { get; set; }
        public required string Password { get; set; }
        public RoleType_User Role { get; set; }
        public List<Course> courses { get; set; } = new List<Course>();
    }
    public class UserSigning
    {
        [EmailAddress]
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
