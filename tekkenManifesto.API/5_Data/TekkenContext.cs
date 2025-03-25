using Microsoft.EntityFrameworkCore;
using tekkenManifesto.API.Model;

namespace tekkenManifesto.API.Data;

public partial class TekkenContext : DbContext
{
    public TekkenContext(){}
    public TekkenContext(DbContextOptions<TekkenContext> options) : base(options){}

    public virtual DbSet<Character> Chars { get; set; }
    public virtual DbSet<Combo> Combos { get; set; }
}