using AutoMapper;
using ClientTransactionAPI.DTOs.Request;
using ClientTransactionAPI.DTOs.Response;
using ClientTransactionAPI.Models;

namespace ClientTransactionAPI.DTOs.Mappers;

public class TransactionDTOMapping : Profile
{
    public TransactionDTOMapping()
    {
        CreateMap<Transaction, TransactionRequest>().ReverseMap();
        CreateMap<Transaction, TransactionResponse>().ReverseMap();
    }
}