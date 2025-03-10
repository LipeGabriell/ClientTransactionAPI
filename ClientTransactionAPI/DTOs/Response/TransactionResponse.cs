using ClientTransactionAPI.Models.Enums;

namespace ClientTransactionAPI.DTOs.Request;

public class TransactionResponse
{
    public required TransactionType Type { get; init; }
    public required float Value { get; init; }
    public required DateTime Date { get; init; }
}