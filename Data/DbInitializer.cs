using FilmClub.Services.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FilmClub.Services.Data
{
    public static class DbInitializer
    {
        public static void Initialize(FilmClubContext context)
        {
            context.SaveChanges();

            if (context.Films.Any())
            {
                return;
            }

            var films = new Film[]
            {
                new Film{ Id=1, Name = "" },
                new Film{ Id=2, Name = "Mad Max and Mental Mary" },
                new Film{ Id=3, Name = "Before Afternoon Tea" }
            };

            foreach (Film f in films)
            {
                context.Films.Add(f);
            }


            context.SaveChanges();
            var users = new User[]
            {
                new User{ Id=1, Name = "Jim" },
                new User{ Id=2, Name = "Jam" },
                new User{ Id=3, Name = "Jom" }
            };

            foreach (User u in users)
            {
                context.Users.Add(u);
            }

            context.SaveChanges();
        }
    }
}