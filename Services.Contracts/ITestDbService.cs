
using Shared.DTO.Test;

namespace Services.Contracts;

public interface ITestDbService
{
    Task<IEnumerable<TesDbRecord>> GetAllTestDBsAsync();
    Task CreateTestDB(TestDBCreate testDb);
}
