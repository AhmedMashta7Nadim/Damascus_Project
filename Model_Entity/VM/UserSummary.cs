using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model_Entity.Enum_Class;
using Model_Entity.Models;

namespace Model_Entity.VM
{
    public class UserSummary:Entity_ID
    {
        public required string Name { get; set; }
        [EmailAddress]
        public required string Email { get; set; }
        public RoleType_User Role { get; set; }
    }
}
