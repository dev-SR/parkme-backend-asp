using Domain.Contracts;
using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories;

public class RefreshTokenRepository : RepositoryBase<RefreshToken>, IRefreshTokenRepository
{
    public RefreshTokenRepository(RepositoryDbContext dbContext) : base(dbContext) { }


    public async Task<RefreshToken?> GetRefreshTokenByToken(string refreshToken) =>
        await FindByCondition(r => r.Token.Equals(refreshToken), trackChanges: false)
                .Include(r => r.User)
                .SingleOrDefaultAsync();

    public async Task<RefreshToken?> GetRefreshTokenByUser(User user) =>
        await FindByCondition(r => r.UserId.Equals(user.Id), trackChanges: false).SingleOrDefaultAsync();



    public void SaveRefreshToken(RefreshToken refreshToken) => Create(refreshToken);
    public void DeleteRefreshToken(RefreshToken refreshToken) => Delete(refreshToken);

}
