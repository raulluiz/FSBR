using Core.Entities;
using Ibge.API.Infra.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace Ibge.API.Infra.Context;

public class IbgeContext(DbContextOptions<IbgeContext> options) : DbContext(options)
{
    public DbSet<Processo> Processo { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.ApplyConfiguration.Remove<PluralizingTableNameConvention>(); //plularização de objetos
        //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); //deleção em cascata de filho
        modelBuilder.ApplyConfiguration(new ProcessoConfig());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Ibge;Trusted_Connection=True;");
        }
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    var config = new ConfigurationBuilder()
    //        //.SetBasePath(Directory.GetCurrentDirectory())
    //        //.AddJsonFile("appsettings.json")
    //        .Build();
    //    optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
    //}

}