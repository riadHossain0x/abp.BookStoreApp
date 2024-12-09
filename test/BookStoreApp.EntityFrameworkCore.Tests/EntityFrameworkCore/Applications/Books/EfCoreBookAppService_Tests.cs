using BookStoreApp.Books;
using Shouldly;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Validation;
using Xunit;

namespace BookStoreApp.EntityFrameworkCore.Applications.Books;

public class EfCoreBookAppService_Tests : BookAppService_Tests<BookStoreAppEntityFrameworkCoreModule>
{
    [Fact]
    public async Task Should_Not_Create_A_Book_Withoud_Name()
    {
        var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
        {
            await _bookAppService.CreateAsync(
                new CreateUpdateBookDto
                {
                    Name = "",
                    Price = 10,
                    PublishDate = DateTime.Now,
                    Type = BookType.ScienceFiction
                });
        });

        exception.ValidationErrors.ShouldContain(err => err.MemberNames.Any(mem => mem == "Name"));
    }
}
