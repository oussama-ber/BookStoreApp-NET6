using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BookStoreApp.API.Data
{
    public partial class BookStoreDbContext : IdentityDbContext<ApiUser>
    {
        public BookStoreDbContext()
        {
        }

        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Author>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Bio).HasMaxLength(250);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            modelBuilder.Entity<Author>().HasKey(e => e.Id);



            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasIndex(e => e.Isbn, "UQ__Books__447D36EA1C8CFC35")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
               

                entity.Property(e => e.Image).HasMaxLength(250);

                entity.Property(e => e.Isbn)
                    .HasMaxLength(50)
                    .HasColumnName("ISBN");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Summary).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_Books_ToTable");
            });
            modelBuilder.Entity<Book>().HasKey(e => e.Id);

            // to set things by default.
            modelBuilder.Entity<IdentityRole>().HasData(
             new IdentityRole
             {
                 Name = "User",
                 NormalizedName = "USER",
                 Id = "6449c5cb-98bc-470e-9925-aaaa3b4b9eb0"
             },
              new IdentityRole
              {
                  Name = "Administrator",
                  NormalizedName = "ADMINISTRATOR",
                  Id = "27c98c9f-39c3-48a3-8508-4867f55438ae"
              }
                );
            var hasher = new PasswordHasher<ApiUser>(); 

            modelBuilder.Entity<ApiUser>().HasData(
            new ApiUser
            {
                Id = "28abad97-e736-4145-bc4d-fb98958e1704",
                Email = "admin@bookstore.com",
                NormalizedEmail = "ADMIN@BOOKSTORE.COM",
                UserName = "admin@bookstore.com", 
                NormalizedUserName = "ADMIN@BOOKSTORE.COM",
                FirstName = "System",
                LastName = "Admin",
                PasswordHash = hasher.HashPassword(null, "P@ssword1")

            },
             new ApiUser
             {
                 Id = "0589e81b-acb0-46cc-9c6f-5549d07d9304",
                 Email = "user@bookstore.com",
                 NormalizedEmail = "USER@BOOKSTORE.COM",
                 UserName = "user@bookstore.com",
                 NormalizedUserName = "USER@BOOKSTORE.COM",
                 FirstName = "System",
                 LastName = "User",
                 PasswordHash = hasher.HashPassword(null, "P@ssword1")
             }
               );
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "6449c5cb-98bc-470e-9925-aaaa3b4b9eb0", 
                    UserId = "0589e81b-acb0-46cc-9c6f-5549d07d9304"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "27c98c9f-39c3-48a3-8508-4867f55438ae",
                    UserId = "28abad97-e736-4145-bc4d-fb98958e1704"
                }
                );

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
