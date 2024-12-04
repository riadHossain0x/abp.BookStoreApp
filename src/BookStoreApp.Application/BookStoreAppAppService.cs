using BookStoreApp.Localization;
using Volo.Abp.Application.Services;

namespace BookStoreApp;

/* Inherit your application services from this class.
 */
public abstract class BookStoreAppAppService : ApplicationService
{
    protected BookStoreAppAppService()
    {
        LocalizationResource = typeof(BookStoreAppResource);
    }
}
