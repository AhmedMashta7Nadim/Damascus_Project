using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfraStractur.Repository;

namespace InfraStractur.UnitOfWork
{
    public interface IUnit:IDisposable
    {
        IServisesRepository<T, V> Repository<T, V>() where T : class
           where V : class;
    }
}
