using System.Threading.Tasks;

namespace XXG.Frm.Data
{
    public interface IFrmDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
