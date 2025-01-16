using System;
using Domain.Entities.Models;

namespace Domain.Contracts;

public interface ITestDbRepository
{
    Task<IEnumerable<TestDB>> GetAllTestDBsAsync();
    void CreateTestDB(TestDB testDb);

}
