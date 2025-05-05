using PrevDent.Domain.Entities;

namespace prevdent.Application.Services.Interfaces;

public interface IViaCepApplicationService
{
    Task<ViaCepResponseEntity> GetAddressByCep(string cep);
    string ValidateCep(string cep);
}