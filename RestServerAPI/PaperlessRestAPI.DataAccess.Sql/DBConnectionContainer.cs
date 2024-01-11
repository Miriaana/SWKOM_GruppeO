using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessRestAPI.DataAccess.Sql
{
    public class DbConnectionStringContainer : IDbConnectionStringContainer
    {
    
        public DbConnectionStringContainer(DatabaseOptions options)
        {
            this.connectionString =
                $"Host={options.Host};Port={options.Port};Database={options.Database};Username={options.Username};Password={options.Password}";
        }

        public string GetConnectionString()
        {
            return connectionString;
        }

        private readonly string connectionString;
    
    }
}
