using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model_Entity.Enum_Class;

namespace Model_Entity.DTO
{
    public class UserDTO
    {
        public required string Name { get; set; }
        [EmailAddress]
        public required string Email { get; set; }
        public required string Password { get; set; }
        public RoleType_User Role { get; set; }
    }
}
