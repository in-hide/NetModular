using NetModular.Lib.Data.Abstractions;

namespace NetModular.Module.Admin.Infrastructure.Repositories.SQLite
{
    public class RolePageRepository : SqlServer.RolePageRepository
    {
        public RolePageRepository(IDbContext context) : base(context)
        {
        }
    }
}
