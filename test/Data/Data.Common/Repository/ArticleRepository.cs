using System.Threading.Tasks;
using Data.Common.Domain;
using NetModular.Lib.Data.Abstractions;
using NetModular.Lib.Data.Core;

namespace Data.Common.Repository
{
    public class ArticleRepository : RepositoryAbstract<ArticleEntity>, IArticleRepository
    {
        public ArticleRepository(IDbContext context) : base(context)
        {
        }

        public Task<long> Count()
        {
            return Db.Find().CountAsync();
        }

        public Task<bool> AddCount(int id, int count)
        {
            var query = Db.Find(m => m.Id == id);
            return query.UpdateAsync(m => new ArticleEntity
            {
                ReadCount = m.ReadCount + count
            });
        }
    }
}
