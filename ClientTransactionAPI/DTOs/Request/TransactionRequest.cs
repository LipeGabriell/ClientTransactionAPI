using ClientTransactionAPI.Models.Enums;

namespace ClientTransactionAPI.DTOs.Request;

public class TransactionRequest
{
    public TransactionType? Type { get; init; }
    public float? Value { get; init; }
    public DateTime? Date { get; init; }
}