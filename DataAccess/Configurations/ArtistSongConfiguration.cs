using HomeWork.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWork.DataAccess.Configurations
{
    public class ArtistSongConfiguration : IEntityTypeConfiguration<ArtistSong>
    {
        public void Configure(EntityTypeBuilder<ArtistSong> builder)
        {
            builder.HasData(
                new ArtistSong()
                {
                    Id = 1,
                    ArtistId = 2,
                    SongId = 1
                },
                new ArtistSong()
                {
                    Id = 2,
                    ArtistId = 2,
                    SongId = 2
                },
                new ArtistSong()
                {
                    Id = 3,
                    ArtistId = 4,
                    SongId = 1
                },
                new ArtistSong()
                {
                    Id = 4,
                    ArtistId = 3,
                    SongId = 3
                },
                new ArtistSong()
                {
                    Id = 5,
                    ArtistId = 5,
                    SongId = 5
                });
        }
    }
}