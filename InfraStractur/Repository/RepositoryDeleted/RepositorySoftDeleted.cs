using InfraStractur.Data;
using Microsoft.EntityFrameworkCore;
using Model_Entity.Models;

namespace InfraStractur.Repository.RepositoryDeleted
{
    //public abstract class RepositorySoftDeleted<Z> : IRepositorySoftDeleted
    //    where Z : Entity_ID
    //{
    //    private readonly ConnectionDataBase context;

    //    public RepositorySoftDeleted(ConnectionDataBase context)
    //    {
    //        this.context = context;
    //    }

    //    public async Task<string> SoftDeletedAsync(Guid id)
    //    {
    //        var entity = await context.Set<Z>()
    //            .FirstOrDefaultAsync(x => x.Id == id);

    //        if (entity == null)
    //        {
    //            return "Entity not found";
    //        }

    //        // تطبيق الحذف المنطقي
    //        entity.IsActive = true; // يجب أن تكون خاصية IsDeleted موجودة في الكيان Z
    //        context.Update(entity);
    //        await context.SaveChangesAsync();

    //        return "Entity marked as deleted successfully";
    //    }
    //}
}
