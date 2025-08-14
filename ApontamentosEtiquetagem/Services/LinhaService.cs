using ApontamentoEtiquetagem.Dto.Response.Error;
using ApontamentosEtiquetagem.Dto.Response;
using ApontamentosEtiquetagem.Utils.Constants;
using System.Text.Json;

namespace ApontamentosProducao.Services
{
    public class LinhaService
    {
        private readonly HttpClient _httpClient;
        public LinhaService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(HttpRequestConstants.requestUrlLocal)
            };
        }
        public async Task<List<ProducaoEsteiraResponseDto>> CarregarLinhaAsync(int galpaoid)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"ProducaoEsteira/{galpaoid}");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    List<ProducaoEsteiraResponseDto> lista = JsonSerializer.Deserialize<List<ProducaoEsteiraResponseDto>>(json, options);
                    return lista ?? new List<ProducaoEsteiraResponseDto>();
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
                    catch (JsonException)
                    {
                        // Caso o corpo não esteja no formato esperado
                        throw new HttpRequestException($"Erro desconhecido. Resposta bruta: {responseContent}");
                    }
                }
            }
            catch (Exception ex)
            {
                // Tratamento de qualquer erro não previsto
                throw new ApplicationException("Erro inesperado", ex);
            }
        }
    }
}
