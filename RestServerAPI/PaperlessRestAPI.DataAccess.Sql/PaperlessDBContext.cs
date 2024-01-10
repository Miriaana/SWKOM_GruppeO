using Microsoft.EntityFrameworkCore;
using PaperlessRestAPI.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessRestAPI.DataAccess.Sql
{
    public class PaperlessDbContext : DbContext
    {
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<Correspondents> Correspondents { get; set; }

        public DbSet<Notes> Notes { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<GroupUserMapping> GroupUserMappings { get; set; }
        public DbSet<Group> Groups { get; set; }

        public DbSet<PermissionGroupMapping> PermissionGroupMappings { get; set; }
        public DbSet<PermissionName> PermissionNames { get; set; }

        public PaperlessDbContext(DbContextOptions<PaperlessDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureDocuments(modelBuilder);
            ConfigureDocumentTyp(modelBuilder);
            ConfigureNotes(modelBuilder);
            ConfigureCorrespondents(modelBuilder);

            ConfigurePermissionNames(modelBuilder);
            ConfigurePermissionGroupMapping(modelBuilder);
            ConfigureGroup(modelBuilder);
            ConfigureGroupUserMapping(modelBuilder);
            ConfigureUser(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void ConfigureDocuments(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Document>()
                .HasKey(d => d.Id);

            modelBuilder.Entity<Document>()
                .HasMany(d => d.notes)
                .WithOne()
                .HasForeignKey(n => n.Id);

            modelBuilder.Entity<Document>()
                .HasOne(d => d.Correspondent)
                .WithMany()
                .HasForeignKey(d => d.CorrespondentId);

            modelBuilder.Entity<Document>()
                .HasOne(d => d.Document_Type)
                .WithMany()
                .HasForeignKey(d => d.DocumentTypeId);

            modelBuilder.Entity<Document>()
                .HasOne(d => d.Owner)
                .WithMany()
                .HasForeignKey(d => d.OwnerId);

            modelBuilder.Entity<Document>()
                .HasMany<Notes>()
                .WithOne()
                .HasForeignKey(n => n.DocumentId);
        }

        private void ConfigureDocumentTyp(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DocumentType>()
                .HasKey(d => d.Id);

            modelBuilder.Entity<DocumentType>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(d => d.Owner);
        }

        private void ConfigureCorrespondents(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Correspondents>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Correspondents>()
                .HasOne(c => c.LastCorrespondents)
                .WithOne()
                .HasForeignKey<Correspondents>(c => c.LastCorrespondentsId);

            modelBuilder.Entity<Correspondents>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(c => c.Owner);
        }

        private void ConfigurePermissionNames(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PermissionName>()
                .HasKey(p => p.Name);
        }

        private void ConfigurePermissionGroupMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PermissionGroupMapping>()
                .HasKey(p => new { p.GroupId, p.PermissionName });

            modelBuilder.Entity<PermissionGroupMapping>()
                .HasOne<PermissionName>()
                .WithMany()
                .HasForeignKey(p => p.PermissionName);

            modelBuilder.Entity<PermissionGroupMapping>()
                .HasOne<Group>()
                .WithMany()
                .HasForeignKey(p => p.GroupId);
        }

        private void ConfigureGroup(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>()
                .HasKey(g => g.Id);
        }

        private void ConfigureGroupUserMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GroupUserMapping>()
                .HasKey(g => new { g.GroupId, g.UserId });

            modelBuilder.Entity<GroupUserMapping>()
                .HasOne<Group>()
                .WithMany()
                .HasForeignKey(g => g.GroupId);

            modelBuilder.Entity<GroupUserMapping>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(g => g.UserId);
        }

        private void ConfigureUser(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);
        }

        private void ConfigureNotes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Notes>()
                .HasKey(n => new { n.Id, n.DocumentId });

            modelBuilder.Entity<Notes>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(n => n.UserId);
        }
    }
}
