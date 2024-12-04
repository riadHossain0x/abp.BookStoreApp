using Volo.Abp.Modularity;

namespace BookStoreApp;

public abstract class BookStoreAppApplicationTestBase<TStartupModule> : BookStoreAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
