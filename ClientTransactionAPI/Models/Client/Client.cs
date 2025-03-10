using System.ComponentModel.DataAnnotations;

namespace ClientTransactionAPI.Models.Client;

public class Client
{
    [Key] public required int Id { get; init; }
    public required string Name { get; init; }
    public required string Cpf { get; init; }
    public IEnumerable<Transaction.Transaction>? Transactions { get; init; }
}