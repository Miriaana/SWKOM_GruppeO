using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessRestAPI.DataAccess.Sql
{
    public class PaperlessDbContextFactory
    {
        public PaperlessDbContextFactory(IDbConnectionStringContainer connectionStringContainer)
        {
            this.connectionStringContainer = connectionStringContainer;
        }

        public PaperlessDbContext Create()
        {
            var optionsBuilder = new DbContextOptionsBuilder<PaperlessDbContext>();
            optionsBuilder.UseNpgsql(connectionStringContainer.GetConnectionString());
            return new PaperlessDbContext(optionsBuilder.Options);
        }

        private readonly IDbConnectionStringContainer connectionStringContainer;
    }
}
