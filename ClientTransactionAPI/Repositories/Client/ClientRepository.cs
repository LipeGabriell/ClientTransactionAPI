using ClientTransactionAPI.Contexts;
using ClientTransactionAPI.Repositories.Generic;

namespace ClientTransactionAPI.Repositories.Client;

public class ClientRepository(ApplicationDbContext context)
    : Repository<Models.Client>(context), IClientRepository
{
}