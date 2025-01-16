using System;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Contracts;
using Domain.Entities.Models;
using Services.Contracts;
using Shared.DTO.Test;

namespace Services;

public class TestDbService : ITestDbService
{
    public TestDbService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
    {
        RepositoryManager = repositoryManager;
        Logger = logger;
        Mapper = mapper;
    }

    public IRepositoryManager RepositoryManager { get; }
    public ILoggerManager Logger { get; }
    public IMapper Mapper { get; }

    public async Task CreateTestDB(TestDBCreate testDb)
    {
        var testDbRecord = Mapper.Map<TestDB>(testDb);
        RepositoryManager.TestDb.CreateTestDB(testDbRecord);
        await RepositoryManager.SaveAsync();

    }

    public async Task<IEnumerable<TesDbRecord>> GetAllTestDBsAsync()
    {
        var res = await RepositoryManager.TestDb.GetAllTestDBsAsync();
        return Mapper.Map<IEnumerable<TesDbRecord>>(res);
    }
}
