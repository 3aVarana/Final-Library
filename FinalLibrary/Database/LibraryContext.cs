using System;
using FinalLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FinalLibrary.Database
{
    public class LibraryContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<ReaderBook> ReaderBooks { get; set; }


        public LibraryContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            this._configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("sqlConnectionString"));
        }
    }
}
