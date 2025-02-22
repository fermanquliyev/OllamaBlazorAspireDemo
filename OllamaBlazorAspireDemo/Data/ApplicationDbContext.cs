using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OllamaBlazorAspireDemo.Data.Entities;

namespace OllamaBlazorAspireDemo.Data;

public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
{
    //public ApplicationDbContext()
    //{
        
    //}
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<UserChat>().HasKey(x => x.Id);
        builder.Entity<UserChat>().HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId);
        builder.Entity<UserChat>().Property(x => x.ChatJson).HasColumnType("text");
        base.OnModelCreating(builder);
    }
    public DbSet<UserChat> Chats { get; set; }
}
