using ClientTransactionAPI.Contexts;
using ClientTransactionAPI.Repositories.Generic;

namespace ClientTransactionAPI.Repositories.Transaction;

public class TransactionRepository(ApplicationDbContext context)
    : Repository<Models.Transaction.Transaction>(context), ITransactionRepository
{
}