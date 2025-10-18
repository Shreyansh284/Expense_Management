using Core.Interfaces.Repositories;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class UnitOfWork(AppDbContext context):IUnitOfWork
{
    public async Task<int> SaveChangesAsync() => await context.SaveChangesAsync();
}