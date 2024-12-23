using App_ClassLibrary.Contracts;

namespace App_ClassLibrary
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migrationg started at {0}" + DateTime.Now);

            // Details of migrating the database

            _logger.LogInfo("Migrationg finished at {0}" + DateTime.Now);
        }
        public static void Run()
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\Projects\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
