using Microsoft.EntityFrameworkCore;
using PaperlessRestAPI.DataAccess.Entities;
using Document = PaperlessRestAPI.BusinessLogic.Entities.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PaperlessRestAPI.DataAccess.Sql
{
    public class PaperlessDbContext : DbContext
    {
        public DbSet<Document> Documents { get; set; }
    
        public PaperlessDbContext(DbContextOptions<PaperlessDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureDocuments(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private void ConfigureDocuments(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Document>()
                .HasKey(d => d.Id);

            /* modelBuilder.Entity<Document>()
                 .HasMany(d => d.notes)
                 .WithOne()
                 .HasForeignKey(n => n.Id);

             modelBuilder.Entity<Document>()
                 .HasOne(d => d.Document_Type)
                 .WithMany()
                 .HasForeignKey(d => d.DocumentTypeId);*/

            /* modelBuilder.Entity<Document>()
                 .HasOne(d => d.Owner)
                 .WithMany()
                 .HasForeignKey(d => d.OwnerId);*/

            /* modelBuilder.Entity<Document>()
                 .HasMany<Notes>()
                 .WithOne()
                 .HasForeignKey(n => n.DocumentId);*/
        }
    }
}
