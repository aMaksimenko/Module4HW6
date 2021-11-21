using HomeWork.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HomeWork
{
    public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var contextOptions = new DbContextOptionsBuilder<ApplicationContext>()
                .UseSqlServer(configuration.GetConnectionString("HomeWork"))
                .Options;

            return new ApplicationContext(contextOptions);
        }
    }
}