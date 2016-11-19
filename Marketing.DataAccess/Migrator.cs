using Marketing.DataAccess.Migrations;
using System.Data.Entity;

namespace Marketing.DataAccess
{
    public class Migrator : MigrateDatabaseToLatestVersion<Context, Configuration>
    {
    }
}
