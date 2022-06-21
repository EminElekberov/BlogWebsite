using Entity;
using Entity.Concencrate;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class MyContext : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-J12R9UI\\SQLEXPRESS;Database=CoreDemo;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>().
                HasOne(x => x.Hometeam)
                .WithMany(x => x.HomeMatches)
                .HasForeignKey(z => z.HomeTeamId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Match>()
                .HasOne(x => x.GuestTEam)
                .WithMany(x => x.AwayMatch)
                .HasForeignKey(x => x.GuestTeamId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>()
                .HasOne(x => x.SenderUser)
                .WithMany(x => x.WriterSender)
                .HasForeignKey(x => x.SenderId)
                .OnDelete(DeleteBehavior.ClientSetNull);


            modelBuilder.Entity<Message2>()
                .HasOne(x => x.ReceiverUser)
                .WithMany(x => x.WriterReceiver)
                .HasForeignKey(x => x.ReceiverId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Message2> Message2s { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NewsLater> NewsLaters { get; set; }
        public DbSet<BlogRayting> BlogRaytings { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Match> Matches { get; set; }
    }
}
