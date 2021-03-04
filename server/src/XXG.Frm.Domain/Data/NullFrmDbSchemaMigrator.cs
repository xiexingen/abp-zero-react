using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace XXG.Frm.Data
{
    /* This is used if database provider does't define
     * IFrmDbSchemaMigrator implementation.
     */
    public class NullFrmDbSchemaMigrator : IFrmDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}