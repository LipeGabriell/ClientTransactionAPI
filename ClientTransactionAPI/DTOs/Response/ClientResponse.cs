namespace ClientTransactionAPI.DTOs.Response;

public class ClientResponse
{
    public required int Id { get; init; }
    public required string Name { get; init; }
    public required string Cpf { get; init; }
}