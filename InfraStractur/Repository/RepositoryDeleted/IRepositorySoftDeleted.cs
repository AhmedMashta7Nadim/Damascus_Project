using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model_Entity.Models;

namespace InfraStractur.Repository.RepositoryDeleted
{
    public interface IRepositorySoftDeleted
    {
        Task<string> SoftDeletedAsync(Guid Id);
    }
}
