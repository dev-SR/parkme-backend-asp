using System;
using Bogus;
using Domain.Entities.Models;

namespace Infrastructure.Data.Seeding;

public class SeedTestDb
{
    public static IEnumerable<TestDB> generateSeedData(int count = 10)
    {

        var faker = new Faker<TestDB>()
            .RuleFor(p => p.Id, f => Guid.NewGuid())
            .RuleFor(p => p.Value, f => f.Lorem.Word());

        return faker.Generate(count);

    }
}
