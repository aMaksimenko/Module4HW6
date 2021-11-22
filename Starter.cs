using System;
using System.Linq;
using HomeWork.DataAccess;
using HomeWork.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;

namespace HomeWork
{
    public class Starter
    {
        public void Run()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var contextOptions = new DbContextOptionsBuilder<ApplicationContext>()
                .UseSqlServer(configuration.GetConnectionString("HomeWork"))
                .Options;

            using (var db = new ApplicationContext(contextOptions))
            {
                db.Database.Migrate();

                /*var songsWithGenre = db.Songs
                    .Where(s => s.GenreId != null)
                    .Join(
                        db.Genres,
                        s => s.GenreId,
                        g => g.Id,
                        (s, g) => new
                        {
                            s.Id,
                            SongTitle = s.Title,
                            GenreTitle = g.Title
                        })
                    .Join(
                        db.ArtistSongs,
                        s => s.Id,
                        ars => ars.SongId,
                        (s, ars) => new
                        {
                            s.SongTitle,
                            s.GenreTitle,
                            ars.ArtistId
                        })
                    .Join(
                        db.Artists,
                        ars => ars.ArtistId,
                        art => art.Id,
                        (ars, art) => new
                        {
                            ars.SongTitle,
                            ars.GenreTitle,
                            ArtistName = art.Name,
                            ArtistDOB = art.DateOfBirth
                        })
                    .Where(i => EF.Functions.DateDiffYear(i.ArtistDOB, DateTime.UtcNow) < 20)
                    .ToList();

                foreach (var item in songsWithGenre)
                {
                    Console.WriteLine($"{item.SongTitle}, {item.ArtistName} - {item.GenreTitle}");
                }*/

                var songsByGenre = db.Songs
                    .Include(s => s.Genre)
                    .GroupBy(x => x.Genre.Title)
                    .Select(x => new
                    {
                        GenreTitle = x.Key == null ? "Without genre" : x.Key,
                        SongsCount = x.Count()
                    })
                    .ToList();

                foreach (var item in songsByGenre)
                {
                    Console.WriteLine($"{item.GenreTitle}: {item.SongsCount}");
                }

                /*var maxDateOfBirth = db.Artists.Max(a => a.DateOfBirth);
                var oldestSongs = db.Songs.Where(s => s.ReleaseDate < maxDateOfBirth).ToList();

                foreach (var item in oldestSongs)
                {
                    Console.WriteLine($"{item.Title}");
                }*/

                db.SaveChanges();
            }
        }
    }
}