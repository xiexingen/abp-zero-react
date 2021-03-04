using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace XXG.Frm.EntityFrameworkCore
{
    public static class FrmDbContextModelCreatingExtensions
    {
        public static void ConfigureFrm(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(FrmConsts.DbTablePrefix + "YourEntities", FrmConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}