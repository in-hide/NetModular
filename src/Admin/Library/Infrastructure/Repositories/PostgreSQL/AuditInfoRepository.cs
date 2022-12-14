using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetModular.Lib.Data.Abstractions;
using NetModular.Lib.Utils.Core.Result;

namespace NetModular.Module.Admin.Infrastructure.Repositories.PostgreSQL
{
    public class AuditInfoRepository : SqlServer.AuditInfoRepository
    {
        public AuditInfoRepository(IDbContext context) : base(context)
        {
        }

        public override Task<IEnumerable<ChartDataResultModel>> QueryLatestWeekPv()
        {
            throw new NotImplementedException();

            //var sql = string.Format(AuditInfoSql.QueryLatestWeekPv, Db.EntityDescriptor.TableName);
            //return Db.QueryAsync<ChatDataRow>(sql);
        }
    }
}
