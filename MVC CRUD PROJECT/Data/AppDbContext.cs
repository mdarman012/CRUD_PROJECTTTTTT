using Microsoft.EntityFrameworkCore;
using MVC_CRUD_PROJECT.Models;
namespace MVC_CRUD_PROJECT.Data;


public class AppDbContext : DbContext
{
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { 
    }
    public DbSet<Student> Students { get; set; }
}

