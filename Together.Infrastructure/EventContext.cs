using Microsoft.EntityFrameworkCore;
using Together.Domain.Entity;

namespace Together.Infrastructure;

public class EventContext : DbContext
{
    public string DbPath { get; }
    public EventContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        //DbPath = System.IO.Path.Join(path, "uddd.db");
        DbPath = Path.Join(path, "uddd.db");
    }
    public DbSet<Event>? Events { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=>
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
}