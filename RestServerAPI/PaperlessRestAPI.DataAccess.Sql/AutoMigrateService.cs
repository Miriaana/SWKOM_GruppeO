using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessRestAPI.DataAccess.Sql
{
    public class AutoMigrateService
    {
        private readonly PaperlessDbContextFactory factory;

        public AutoMigrateService(PaperlessDbContextFactory factory)
        {
            this.factory = factory;
        }
        /*
        public void Migrate()
        {
            using PaperlessDbContext dbContext = factory.Create();

            if (dbContext.Database.EnsureCreated())
            {
                dbContext.Database.Migrate();
            }
        }*/
    }
}
