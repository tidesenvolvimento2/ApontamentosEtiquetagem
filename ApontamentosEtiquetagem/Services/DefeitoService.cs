using ApontamentoEtiquetagem.Dto.Response.Error;
using ApontamentosEtiquetagem.Dto.Response;
using ApontamentosEtiquetagem.Dto.Response.Error;
using ApontamentosEtiquetagem.Models;
using ApontamentosEtiquetagem.Utils.Constants;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApontamentosEtiquetagem.Services
{
    public class DefeitoService
    {
        private readonly HttpClient _httpClient;

        public DefeitoService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(HttpRequestConstants.requestUrlLocal)
            };
        }

        public async Task<List<DefeitoResponseDto>> CarregarDefeitosAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("Defeitos");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    List<DefeitoResponseDto> lista = JsonSerializer.Deserialize<List<DefeitoResponseDto>>(json, options);
                    return lista ?? new List<DefeitoResponseDto>();
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
