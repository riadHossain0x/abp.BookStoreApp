using BookStoreApp.Samples;
using Xunit;

namespace BookStoreApp.EntityFrameworkCore.Applications;

[Collection(BookStoreAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BookStoreAppEntityFrameworkCoreTestModule>
{

}
