namespace GetCep.Models;

public class CepResponse
{
    public required string cep { get; set; }
    public required string logradouro { get; set; }
    public required string bairro { get; set; }
    public required string localidade { get; set; }
    public required string uf { get; set; }
    public required string estado { get; set; }
    public string? complemento { get; set; }
    public string? unidade { get; set; }
    public string? regiao { get; set; }
    public string? ibge { get; set; }
    public string? gia { get; set; }
    public string? ddd { get; set; }
    public string? siafi { get; set; }
}