using System;
using System.Collections.Generic;
using DAL;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Persistence.Context
{
    public partial class BookablesProjectContext : DbContext
    {
        public BookablesProjectContext()
        {
        }

        public BookablesProjectContext(DbContextOptions<BookablesProjectContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=MSI-GT76\\MSSQLSERVER01;Database=BookablesProject;User Id=Bookable;Password=Bookable");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
            new BookableMap(modelBuilder.Entity<Bookable>());
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
