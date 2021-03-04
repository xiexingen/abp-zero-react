using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using XXG.Frm.Data;
using Volo.Abp.DependencyInjection;

namespace XXG.Frm.EntityFrameworkCore
{
    public class EntityFrameworkCoreFrmDbSchemaMigrator
        : IFrmDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreFrmDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the FrmMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<FrmMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}