using System.Transactions;
using Infrastructure.Persistence.Ef;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DGLand.Logistic.Tests.Persistence;

public abstract class BasePersistenceTest : IDisposable
{
    private readonly TransactionScope _transactionScope;
    public ApplicationDbContext _DbContext { get; private set; }

    protected BasePersistenceTest()
    {
        var optionsBuilder = GetDbContextOptionsBuilder();
        UpdateDatabase(optionsBuilder).Wait();
        _transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
        _DbContext = new ApplicationDbContext(optionsBuilder.Options);
    }

    private static DbContextOptionsBuilder<ApplicationDbContext> GetDbContextOptionsBuilder()
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        var configuration = new ConfigurationBuilder() 
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", false)
            .Build();
        var connectionString = configuration.GetConnectionString("SqlServer");
        optionsBuilder.UseSqlServer(connectionString,
            a => a.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
        return optionsBuilder;
    }

    private async Task UpdateDatabase(DbContextOptionsBuilder<ApplicationDbContext> optionsBuilder)
    { 
        var logisticDbContext = new ApplicationDbContext(optionsBuilder.Options);
        await logisticDbContext.Database.MigrateAsync();
        await logisticDbContext.DisposeAsync(); 
    }
    public void Dispose()
    {
        _transactionScope.Dispose();
        _DbContext.Dispose();
    }
}