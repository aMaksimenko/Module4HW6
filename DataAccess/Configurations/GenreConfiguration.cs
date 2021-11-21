using HomeWork.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWork.DataAccess.Configurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(
                new Genre()
                {
                    Id = 1,
                    Title = "Hard rock"
                },
                new Genre()
                {
                    Id = 2,
                    Title = "Pop"
                },
                new Genre()
                {
                    Id = 3,
                    Title = "Country"
                },
                new Genre()
                {
                    Id = 4,
                    Title = "Rap"
                },
                new Genre()
                {
                    Id = 5,
                    Title = "K-pop"
                });
        }
    }
}