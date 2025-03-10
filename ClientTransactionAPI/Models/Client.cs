using System.ComponentModel.DataAnnotations;

namespace ClientTransactionAPI.Models;

public class Client
{
    [Key] public required int Id { get; init; }
    public required string Name { get; init; }
    public required string Cpf { get; init; }
    public IEnumerable<Transaction>? Transactions { get; init; }
}