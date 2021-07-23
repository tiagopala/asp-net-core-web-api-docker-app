using AspNetCoreWebApiDockerApp.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AspNetCoreWebApiDockerApp.Api.Repositories.Context
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(IConfiguration configuration, DbContextOptions options) : base(options) { }

        // Tables
        public DbSet<Book> Books { get; set; }
    }
}
