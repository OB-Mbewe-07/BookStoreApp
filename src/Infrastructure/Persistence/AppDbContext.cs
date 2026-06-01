using BookstoreApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace BookstoreApp.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Books> Books => Set<Books>();
}