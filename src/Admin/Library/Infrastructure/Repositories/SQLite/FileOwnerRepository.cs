using NetModular.Lib.Data.Abstractions;

namespace NetModular.Module.Admin.Infrastructure.Repositories.SQLite
{
    public class FileOwnerRepository : SqlServer.FileOwnerRepository
    {
        public FileOwnerRepository(IDbContext context) : base(context)
        {
        }
    }
}
