using GetCep.Models;

namespace GetCep.Interfaces;

public interface ICepInterface
{
    Task<CepResponse?> GetCepAsync(string number);
}