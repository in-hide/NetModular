using NetModular.Lib.Data.Abstractions;
using NetModular.Lib.Data.Core;

namespace Data.Common
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(IDbContextOptions options) : base(options)
        {

        }
    }
}
