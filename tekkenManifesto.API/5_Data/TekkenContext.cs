using Microsoft.EntityFrameworkCore;
using tekkenManifesto.API.Model;

namespace tekkenManifesto.API.Data;

public partial class TekkenContext : DbContext
{
    public TekkenContext(){}
    public TekkenContext(DbContextOptions<TekkenContext> options) : base(options){}

    public virtual DbSet<Character> Chars { get; set; }
    public virtual DbSet<Combo> Combos { get; set; }
    public virtual DbSet<HeatEngager> HeatEngagers { get; set; }
    public virtual DbSet<Launcher> Launchers { get; set; }
    public virtual DbSet<Punisher> Punishers { get; set; }
    public virtual DbSet<Stance> Stances { get; set; }
}