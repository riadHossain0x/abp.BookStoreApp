using Microsoft.Extensions.Localization;
using BookStoreApp.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BookStoreApp;

[Dependency(ReplaceServices = true)]
public class BookStoreAppBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<BookStoreAppResource> _localizer;

    public BookStoreAppBrandingProvider(IStringLocalizer<BookStoreAppResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
