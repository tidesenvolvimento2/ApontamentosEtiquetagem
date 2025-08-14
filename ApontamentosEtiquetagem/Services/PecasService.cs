using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using ApontamentoEtiquetagem.Dto.Response;
using ApontamentoEtiquetagem.Dto.Response.Error;
using System.Windows.Forms;
using ApontamentosEtiquetagem.Utils.Constants;


namespace ApontamentoEtiquetagem.Services
{
    public class PecasService
    {
        public readonly HttpClient _httpClient;
        public PecasService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(HttpRequestConstants.requestUrlLocal)
            };
        }

        public async Task<PecaResponseDto> CarregarPecasAsync(string codigo)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"Produtos/{codigo}");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    PecaResponseDto lista = JsonSerializer.Deserialize<PecaResponseDto>(json, options);
                    return lista ?? new PecaResponseDto();
                }
                else
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    try
                    {
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
                        throw new HttpRequestException($"Erro desconhecido. Resposta bruta: {responseContent}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new HttpRequestException($"Erro inesperado", ex);
            }
        }

    }
}
