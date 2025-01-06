using System;
using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class RoleConfiguration : IEntityTypeConfiguration<MyRole>
{
    public void Configure(EntityTypeBuilder<MyRole> builder)
    {
        builder.HasData(
            new MyRole
            {
                Id = Guid.NewGuid(),
                Name = "User",
                NormalizedName = "USER"
            },
            new MyRole
            {
                Id = Guid.NewGuid(),
                Name = "Admin",
                NormalizedName = "ADMIN"
            }
        );
    }
}