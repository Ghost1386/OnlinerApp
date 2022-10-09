using Microsoft.EntityFrameworkCore;
using OnlinerApp.Model.Models;

namespace OnlinerApp.Model;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
    }
    
    public DbSet<Fridge> Fridges { get; set; }
    
    public DbSet<Hob> Hobs { get; set; }
    
    public DbSet<Microwave> Microwaves { get; set; }

    public DbSet<Motorbike> Motorbikes { get; set; }
    
    public DbSet<Notebook> Notebooks { get; set; }
    
    public DbSet<Telephone> Telephones { get; set; }
    
    public DbSet<Television> Televisions { get; set; }
    
    public DbSet<User> Users { get; set; }

    public DbSet<VacuumCleaner> VacuumCleaners { get; set; }

    public DbSet<Washer> Washers { get; set; }
    
    public DbSet<Сomputer> Сomputers { get; set; }
}