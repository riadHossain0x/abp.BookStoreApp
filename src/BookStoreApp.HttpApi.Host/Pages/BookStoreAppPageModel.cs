using BookStoreApp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace BookStoreApp.Pages;

public class BookStoreAppPageModel : AbpPageModel
{
    public BookStoreAppPageModel()
    {
        LocalizationResourceType = typeof(BookStoreAppResource);
    }
}
