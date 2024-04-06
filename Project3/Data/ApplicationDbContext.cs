using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project3.Models;

namespace Project3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Project3.Models.Borrowing> Borrowing { get; set; } = default!;
        public DbSet<Project3.Models.Book> Book { get; set; } = default!;
        public DbSet<Project3.Models.Reader> Reader { get; set; } = default!;
    }
}