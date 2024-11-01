using Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = Entities.Concrete.Task;

namespace DataAccessLayer.Context
{
    public class VitaskContext : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=VitaskDb;Username=postgres;Password=123456");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Task>().HasOne(x=>x.Reporter).WithMany(x=>x.ReporterTasks).HasForeignKey(x=>x.ReporterId).OnDelete(DeleteBehavior.NoAction);
            builder.Entity<Task>().HasOne(x => x.Responsible).WithMany(x => x.ResponsibleTasks).HasForeignKey(x => x.ResponsibleId).OnDelete(DeleteBehavior.NoAction);
            base.OnModelCreating(builder);
        }
        public DbSet<AppRole> AppRoles { get; set; }    
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }  
        public DbSet<Project > Projects { get; set; }
        public DbSet<ProjectUser> ProjectUsers { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }

    }
}
