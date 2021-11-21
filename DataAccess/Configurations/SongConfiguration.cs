using System;
using HomeWork.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWork.DataAccess.Configurations
{
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.HasData(
                new Song()
                {
                    Id = 1,
                    Title = "Sonne",
                    Duration = 300000,
                    ReleaseDate = new DateTime(2001, 1, 1),
                    GenreId = 1
                },
                new Song()
                {
                    Id = 2,
                    Title = "Ich tu dir weh",
                    Duration = 300000,
                    ReleaseDate = new DateTime(2009, 1, 1),
                    GenreId = 1
                },
                new Song()
                {
                    Id = 3,
                    Title = "Organization",
                    Duration = 300000,
                    ReleaseDate = new DateTime(2021, 1, 1),
                    GenreId = 4
                },
                new Song()
                {
                    Id = 4,
                    Title = "Wait and bleed",
                    Duration = 300000,
                    ReleaseDate = new DateTime(2004, 1, 1),
                },
                new Song()
                {
                    Id = 5,
                    Title = "Run, nigger, run",
                    Duration = 300000,
                    ReleaseDate = new DateTime(1926, 1, 1),
                });
        }
    }
}