using System.Threading.Tasks;

namespace ABStr.Budget.Manag.Data;

public interface IManagDbSchemaMigrator
{
    Task MigrateAsync();
}
