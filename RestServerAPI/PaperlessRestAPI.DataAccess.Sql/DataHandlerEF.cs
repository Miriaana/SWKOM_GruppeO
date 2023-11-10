using Npgsql.Internal.TypeHandlers.DateTimeHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessRestAPI.DataAccess.Sql
{
    public class DataHandlerEF // : IDataHandler
    {
        IDbConnectionStringContainer connectionStringContainer;
        private PaperlessDbContext context;

        public DataHandlerEF()
        {
            connectionStringContainer = new DbConnectionStringContainer("Host=localhost;Port=5432;Database=paperless;Username=paperless;Password=paperless");
            context = new PaperlessDbContextFactory(connectionStringContainer).Create();

            context.Database.EnsureCreated();
            //context.Tours.Load();
            //context.TourLogs.Load();
        }

        /*
        public Tour AddTour(Tour newTour)
        {
            context.Tours.Add(newTour);
            context.SaveChanges();
            return newTour;
        }*/
    }
}
