using AuthServiceIN6BV.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace AuthServiceIN6BV.Persistence.Data;
public class ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
   public DbSet<User> Users {get; set;}
    public DbSet<userProfile> UserProfiles {get; set;}
    public DbSet<Role> Roles {get; set;}
    public DbSet<UserRole> UserRoles {get; set;}
    public DbSet<UserEmail> UserEmails {get; set;}
    private DbSet<UserPasswordReset> UserPasswordResets {get; set;}
 
 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
 
    public override int SaveChanges()
    {
        return base.SaveChanges();
    }
 
    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }
 
    public void UpdateTimestamps()
    {
       
    }
 
    private static string ToSnakeCase(string input)
    
    {
        return "";
    }
}