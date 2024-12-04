using Volo.Abp.Settings;

namespace BookStoreApp.Settings;

public class BookStoreAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BookStoreAppSettings.MySetting1));
    }
}
