using Xunit;

namespace BookStoreApp.EntityFrameworkCore;

[CollectionDefinition(BookStoreAppTestConsts.CollectionDefinitionName)]
public class BookStoreAppEntityFrameworkCoreCollection : ICollectionFixture<BookStoreAppEntityFrameworkCoreFixture>
{

}
