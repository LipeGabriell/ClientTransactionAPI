using ClientTransactionAPI.Repositories.Generic;

namespace ClientTransactionAPI.Repositories.Transaction;

public interface ITransactionRepository : IRepository<Models.Transaction.Transaction>
{
}