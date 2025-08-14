using System.Text.Json;
using ApontamentoEtiquetagem.Dto.Response.Error;
using ApontamentosEtiquetagem.Utils.Constants;
using ApontamentosEtiquetagem.Dto.Response;

namespace ApontamentosEtiquetagem.Services
{
    public class GalpaoService
    {
        private readonly HttpClient _httpClient;

        public GalpaoService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(HttpRequestConstants.requestUrlLocal)
            };
        }

        public async Task<List<GalpaoResponseDto>> CarregarGalpoesAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("Galpao");
                if(response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    List<GalpaoResponseDto> lista = JsonSerializer.Deserialize<List<GalpaoResponseDto>>(json, options);
                    return lista ?? new List<GalpaoResponseDto>();
                }
                else
                {
                    // Lê o conteúdo da resposta de erro
                    var responseContent = await response.Content.ReadAsStringAsync();

                    try
                    {
                        // Tenta desserializar o JSON de erro
                        var apiError = JsonSerializer.Deserialize<ApiErrorResponse>(
                            responseContent,
                            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                        var mensagens = apiError?.Errors?.MensagemErro != null && apiError.Errors.MensagemErro.Length > 0
                            ? string.Join(" | ", apiError.Errors.MensagemErro)
                            : apiError?.Detail ?? "Erro desconhecido.";

                        throw new HttpRequestException(
                            $"Erro {apiError?.Status} ({apiError?.Title}): {mensagens} [Instance: {apiError?.Instance}]");
                    }
                    catch(JsonException)
                    {
                        // Caso o corpo não esteja no formato esperado
                        throw new HttpRequestException($"Erro desconhecido. Resposta bruta: {responseContent}");
                    }
                }
            }
            catch(Exception ex)
            {
                // Tratamento de qualquer erro não previsto
                throw new ApplicationException("Erro inesperado", ex);
            }
        }
    }
}