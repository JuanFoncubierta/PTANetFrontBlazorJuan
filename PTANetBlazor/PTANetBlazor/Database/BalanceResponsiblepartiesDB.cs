using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PTAJuan.Model;
namespace PTAJuan.Database;

public class BalanceResponsibleContext : DbContext
{
    public BalanceResponsibleContext() : base()
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer();
    }
    public DbSet<BalanceResponsibleParty> balanceResponsibleParties {  get; set; }

}

