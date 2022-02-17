using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABStr.Budget.Manag.Data;

/* This is used if database provider does't define
 * IManagDbSchemaMigrator implementation.
 */
public class NullManagDbSchemaMigrator : IManagDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
