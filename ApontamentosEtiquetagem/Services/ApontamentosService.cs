using System.Text;
using System.Text.Json;
using ApontamentoEtiquetagem.Dto.Response.Error;
using ApontamentosEtiquetagem.Dto.Request;

//using ApontamentosEtiquetagem.Dto.Request;
using ApontamentosEtiquetagem.Dto.Response;
using ApontamentosEtiquetagem.Dto.Response.Apontamentos;

//using ApontamentosEtiquetagem.Dto.Response.ApontamentoDto;
using ApontamentosEtiquetagem.Utils.Constants;
using ApontamentosEtiquetagem.Dto.Response;

namespace ApontamentosEtiquetagem.Services
{
    public class ApontamentosService
    {
        private readonly HttpClient _httpClient;

        public ApontamentosService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(HttpRequestConstants.requestUrlLocal)
            };
        }

        public async Task<string> ContarProducaoPorOpAsync(string Op)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"Apontamento/CountOrdemProducao?Op={Op}");
                if(response.IsSuccessStatusCode)
                {
                    string valor = await response.Content.ReadAsStringAsync();

                    return valor;
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

        public async Task<string> ContarProducaoPorLinhaAsync(int LinhaId)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"Apontamento/Count?Idlinha={LinhaId}");
                if(response.IsSuccessStatusCode)
                {
                    string valor = await response.Content.ReadAsStringAsync();

                    return valor;
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

        public async Task<ApontamentoDto> RegistrarApontamentoAsync(ApontamentoPostDto apontamento)
        {
            try
            {
                // Serializa o objeto apontamento para JSON
                string json = JsonSerializer.Serialize(apontamento);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Envia POST para a API
                HttpResponseMessage response = await _httpClient.PostAsync("Apontamento", content);

                if(response.IsSuccessStatusCode)
                {
                    // Lê e desserializa o JSON de retorno
                    string retornoJson = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    ApontamentoDto lista = JsonSerializer.Deserialize<ApontamentoDto>(retornoJson, options);
                    return lista ?? new ApontamentoDto();
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

        public async Task<ApontamentoDto> RegistrarApontamentoDefeitoAsync(ApontamentoDefeitoPostDto apontamentoDefeito)
        {
            try
            {
                // Serializa o objeto apontamento para JSON
                string json = JsonSerializer.Serialize(apontamentoDefeito);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Envia POST para a API
                HttpResponseMessage response = await _httpClient.PostAsync("Apontamento/Defeito", content);

                if(response.IsSuccessStatusCode)
                {
                    // Lê e desserializa o JSON de retorno
                    string retornoJson = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    ApontamentoDto lista = JsonSerializer.Deserialize<ApontamentoDto>(retornoJson, options);
                    return lista ?? new ApontamentoDto();
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

        public async Task<List<ApontamentoDto>> InicializarUltimosApontamentosAsync(int linha)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"Apontamento?IdLinha={linha}");
                if(response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    List<ApontamentoDto> lista = JsonSerializer.Deserialize<List<ApontamentoDto>>(json, options);
                    return lista ?? new List<ApontamentoDto>();
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

        public async Task<List<ApontamentosDefeitoResponse>> InicializarUltimosApontamentosDefeitoAsync(int linha)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"Apontamento/ApontamentoDefeito/{linha}");
                if(response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    List<ApontamentosDefeitoResponse> lista = JsonSerializer.Deserialize<List<ApontamentosDefeitoResponse>>(json, options);
                    return lista ?? new List<ApontamentosDefeitoResponse>();
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