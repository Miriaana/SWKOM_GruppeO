using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessRestAPI.DataAccess.Sql
{
    public class DbConnectionStringContainer : IDbConnectionStringContainer
    {
        public DbConnectionStringContainer(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public string GetConnectionString()
        {
            return connectionString;
        }

        private readonly string connectionString;
    }
}
