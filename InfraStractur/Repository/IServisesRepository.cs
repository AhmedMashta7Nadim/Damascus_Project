using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfraStractur.Repository.RepositoryDeleted;

namespace InfraStractur.Repository
{
    public interface IServisesRepository<T,V> 
        where T : class 
        where V : class
    {
        Task<List<V>> GetAllAsync();
        Task<T>Add(T item);
    }
}
