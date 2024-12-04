using System.Threading.Tasks;

namespace BookStoreApp.Data;

public interface IBookStoreAppDbSchemaMigrator
{
    Task MigrateAsync();
}
