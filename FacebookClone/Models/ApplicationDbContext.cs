using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FacebookClone.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Post> Posts { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ApplicationUser>()
                .Property(u => u.Id)
                .HasColumnName("UserId");
            modelBuilder.Entity<ApplicationUser>()
                .Property(u => u.FirstName)
                .IsRequired();
            modelBuilder.Entity<ApplicationUser>()
                .Property(u => u.LastName)
                .IsRequired();
            modelBuilder.Entity<ApplicationUser>()
                .HasOptional(u => u.ProfilePicture)
                .WithMany()
                .Map(m => m.MapKey("ProfilePictureId"));
            modelBuilder.Entity<ApplicationUser>()
                .HasRequired(u => u.Gender)
                .WithMany()
                .Map(m => m.MapKey("GenderId"))
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<Post>()
                .HasOptional(p => p.ParentId)
                .WithMany(p => p.ChildPost)
                .Map(m => m.MapKey("ParentId"))
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Post>()
                .HasRequired(p => p.UserId)
                .WithMany()
                .Map(m => m.MapKey("UserId"));

            modelBuilder.Entity<Gender>()
                .Property(p => p.Name)
                .IsRequired();

            base.OnModelCreating(modelBuilder);

        }
    }
}