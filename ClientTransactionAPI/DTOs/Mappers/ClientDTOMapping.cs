using AutoMapper;
using ClientTransactionAPI.DTOs.Request;
using ClientTransactionAPI.DTOs.Response;
using ClientTransactionAPI.Models;

namespace ClientTransactionAPI.DTOs.Mappers;

public class ClientDTOMapping : Profile
{
    public ClientDTOMapping()
    {
        CreateMap<Client, ClientResponse>().ReverseMap();
        CreateMap<Client, ClientRequest>().ReverseMap();
    }
}