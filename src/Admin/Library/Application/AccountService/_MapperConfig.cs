using AutoMapper;
using NetModular.Lib.Mapper.AutoMapper;
using NetModular.Module.Admin.Application.AccountService.ViewModels;
using NetModular.Module.Admin.Domain.Account;

namespace NetModular.Module.Admin.Application.AccountService
{
    public class MapperConfig : IMapperConfig
    {
        public void Bind(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<AccountAddModel, AccountEntity>().ForMember(m => m.Roles, opt => opt.Ignore());
            cfg.CreateMap<AccountSyncModel, AccountEntity>().ForMember(m => m.Roles, opt => opt.Ignore());

            cfg.CreateMap<AccountEntity, AccountUpdateModel>();
            cfg.CreateMap<AccountUpdateModel, AccountEntity>().ForMember(m => m.Roles, opt => opt.Ignore());
        }
    }
}
