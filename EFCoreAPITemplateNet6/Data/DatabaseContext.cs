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
        modelBuilder.Entity<CiMaster>().HasKey(e => new { e.UNIT, e.WELL_ACTIVITY, e.ORGINAZATION, e.ASSET, e.SOURCETYPE });
    }
}