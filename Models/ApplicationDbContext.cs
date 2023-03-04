using CatalogCarDZ.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace CatalogCarDZ.Models
{
    public class ApplicationDbContext:DbContext
    {

        public DbSet<Car> Cars { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }

        // конфигурация контекста
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // получаем файл конфигурации
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            // устанавливаем для контекста строку подключения
            // инициализируем саму строку подключения
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        }


    }
}
