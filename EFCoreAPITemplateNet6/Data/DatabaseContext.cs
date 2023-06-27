using Microsoft.EntityFrameworkCore;
using EFCoreAPITemplateNet6.Models;

namespace EFCoreAPITemplateNet6.Data;

public class DatabaseContext : DbContext
{
    public virtual DbSet<CiMaster> CiMaster { get; set; }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}
