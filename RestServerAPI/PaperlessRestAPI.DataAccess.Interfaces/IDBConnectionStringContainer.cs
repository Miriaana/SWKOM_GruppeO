using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessRestAPI.DataAccess.Sql
{
    public interface IDbConnectionStringContainer
    {
        string GetConnectionString();
    }
}
