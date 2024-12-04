using Volo.Abp.Modularity;

namespace BookStoreApp;

[DependsOn(
    typeof(BookStoreAppDomainModule),
    typeof(BookStoreAppTestBaseModule)
)]
public class BookStoreAppDomainTestModule : AbpModule
{

}
