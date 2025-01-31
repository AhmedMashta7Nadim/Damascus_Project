using AutoMapper;
using InfraStractur.Data;
using InfraStractur.Data.Mapping_Models;
using InfraStractur.Repository.RepositoryDeleted;
using Microsoft.EntityFrameworkCore;
using Model_Entity.Models;

namespace InfraStractur.Repository
{
    public class ServisesRepository<T, V> : IServisesRepository<T, V>,IRepositorySoftDeleted
        where T : class ,IEntity_ID
        where V : class
       
        
    {
        private readonly ConnectionDataBase context;
        private readonly IMapper mapper;

        

        //private readonly IRepositorySoftDeleted repositorySoft;

        public ServisesRepository(ConnectionDataBase context,IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        //public ServisesRepository(ConnectionDataBase context /*, IRepositorySoftDeleted repositorySoft*/)
        //{
        //    this.context = context;
        //    //this.repositorySoft = repositorySoft;
        //}
        public async Task<T> Add(T item)
        {
            var add = await context.AddAsync(item);
            await context.SaveChangesAsync();
            return add.Entity;
        }

        public async Task<List<V>> GetAllAsync()
        {
            try
            {
                var getAll = await context.Set<T>()
               .Where(x => x.IsActive)
               .ToListAsync();
                var xx = typeof(T);
                var zz = typeof(V);

                var mapping = mapper.Map<List<V>>(getAll);

                return mapping;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return new List<V>();
        }

        public async Task<object> GetAsync(Guid id, bool isinclude = false, Func<IQueryable<T>, IQueryable<T>> include = null)
        {
            IQueryable<T> querey =  context.Set<T>();

          
            if(isinclude && include != null)
            {
                querey = include(querey);
            }
            var get = await querey.FirstOrDefaultAsync(x => x.Id == id);
            if (get == null)
            {
                return null;
            }
            return get;
        }

        public async Task<string> SoftDeletedAsync(Guid Id)
        {
            var x=await context.Set<T>().FirstOrDefaultAsync(x=>x.Id==Id);
            if (x == null)
            {
                return null;
            }
            x.IsActive = false;
            await context.SaveChangesAsync();
            return "True";
        }
    }
}
