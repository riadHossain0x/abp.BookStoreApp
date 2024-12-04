using Volo.Abp.Modularity;

namespace BookStoreApp;

[DependsOn(
    typeof(BookStoreAppApplicationModule),
    typeof(BookStoreAppDomainTestModule)
)]
public class BookStoreAppApplicationTestModule : AbpModule
{

}
