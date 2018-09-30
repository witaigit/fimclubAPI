using FilmClub.Services.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmClub.Services.Data
{
    public class FilmClubContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Film> Films { get; set; }

        public FilmClubContext(DbContextOptions<FilmClubContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Film>().ToTable("Films");
        }

    }
}