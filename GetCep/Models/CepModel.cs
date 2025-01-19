using System.Text.Json.Serialization;

namespace GetCep.Models;

public class CepResponse
{
    [JsonPropertyName("cep")]
    public required string Cep { get; set; }
    
    [JsonPropertyName("logradouro")]
    public required string Logradouro { get; set; }
    
    [JsonPropertyName("bairro")]
    public required string Bairro { get; set; }
    
    [JsonPropertyName("localidade")]
    public required string Localidade { get; set; }
    
    [JsonPropertyName("uf")]
    public required string Uf { get; set; }
    
    [JsonPropertyName("estado")]
    public required string Estado { get; set; }
    
    [JsonPropertyName("complemento")]
    public string? Complemento { get; set; }
    
    [JsonPropertyName("unidade")]
    public string? Unidade { get; set; }
    
    [JsonPropertyName("regiao")]
    public string? Regiao { get; set; }
    
    [JsonPropertyName("ibge")]
    public string? Ibge { get; set; }
    
    [JsonPropertyName("gia")]
    public string? Gia { get; set; }
    
    [JsonPropertyName("ddd")]
    public string? Ddd { get; set; }
    
    [JsonPropertyName("siafi")]
    public string? Siafi { get; set; }
}