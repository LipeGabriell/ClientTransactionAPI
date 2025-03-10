using System.ComponentModel.DataAnnotations;
using ClientTransactionAPI.Models.Enums;

namespace ClientTransactionAPI.Models.Transaction;

public class Transaction
{
    [Key] public required int Id { get; init; }
    public required TransactionType Type { get; init; }
    public required float Value { get; init; }
    public required DateTime Date { get; init; }
    public required int ClientId { get; init; }
}