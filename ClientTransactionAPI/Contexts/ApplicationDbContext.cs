using ClientTransactionAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientTransactionAPI.Contexts;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
}