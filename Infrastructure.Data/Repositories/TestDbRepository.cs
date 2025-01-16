using System;
using Domain.Contracts;
using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories;

public class TestDbRepository(RepositoryDbContext dbContext) : RepositoryBase<TestDB>(dbContext), ITestDbRepository
{
    public void CreateTestDB(TestDB testDb) => Create(testDb);

    public async Task<IEnumerable<TestDB>> GetAllTestDBsAsync()
    {
        return await FindAll(false).ToListAsync();
    }
}
