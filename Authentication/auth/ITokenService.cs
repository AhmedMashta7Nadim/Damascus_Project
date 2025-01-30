using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model_Entity.DTO;
using Model_Entity.Models;

namespace Authentication.auth
{
    public interface ITokenService
    {
        string GenerateToken(User UserName);
    }
}
