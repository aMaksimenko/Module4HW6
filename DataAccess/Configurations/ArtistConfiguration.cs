using System;
using HomeWork.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWork.DataAccess.Configurations
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasData(
                new Artist()
                {
                    Id = 1,
                    Name = "Slipknot",
                    DateOfBirth = new DateTime(1995, 1, 1),
                    Email = "slipknot@gmail.com"
                },
                new Artist()
                {
                    Id = 2,
                    Name = "Rammstein",
                    DateOfBirth = new DateTime(1994, 1, 1),
                    Email = "rammstein@gmail.com"
                },
                new Artist()
                {
                    Id = 3,
                    Name = "Oxxxymiron",
                    DateOfBirth = new DateTime(2008, 1, 1),
                    Email = "oxxxymiron@mail.ru"
                },
                new Artist()
                {
                    Id = 4,
                    Name = "Gradnma's Smuzi",
                    DateOfBirth = new DateTime(2018, 1, 1),
                    Email = "stigmata@rambler.ru"
                },
                new Artist()
                {
                    Id = 5,
                    Name = "Skillet Lickers",
                    DateOfBirth = new DateTime(1926, 1, 1),
                    Email = "madonna@yahoo.com"
                });
        }
    }
}