using BookStoreApp.Samples;
using Xunit;

namespace BookStoreApp.EntityFrameworkCore.Domains;

[Collection(BookStoreAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BookStoreAppEntityFrameworkCoreTestModule>
{

}
