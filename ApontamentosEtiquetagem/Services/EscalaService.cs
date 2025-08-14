using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Api_Producao.Model;
using ApontamentoEtiquetagem.Dto.Response.Error;
using ApontamentosEtiquetagem.Dto.Response.Error;
using ApontamentosEtiquetagem.Dto.Response.Escala;
using ApontamentosEtiquetagem.Utils.Constants;

namespace ApontamentosEtiquetagem.Services
{
    public class EscalaService
    {
        private readonly HttpClient _httpClient;

        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions();

        public EscalaService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(HttpRequestConstants.requestUrlLocal),
            };
        }

        public async Task<Escala> RegistrarEntradaAsync(int idLinha, int idColaborador, int origem)
        {
            try
            {
                string rota = $"Escala/Entrada/{idLinha}/{idColaborador}";
                HttpResponseMessage response = await _httpClient.PostAsync(rota, null);

                if (response.IsSuccessStatusCode)
                {
                    // Sucesso: desserializa o Escala de volta
                    string json = await response.Content.ReadAsStringAsync();
                    var dto = JsonSerializer.Deserialize<Escala>(json, _jsonOptions);
                    return dto ?? new Escala();
                }
                else
                {
                    // Erro HTTP: lê o corpo
                    string responseContent = await response.Content.ReadAsStringAsync();

                    try
                    {
                        // Tenta desserializar o JSON de erro
                        var apiError = JsonSerializer.Deserialize<ApiErrorResponse>(
                            responseContent,
                            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                        // Monta a mensagem de erro
                        var mensagens = apiError?.Errors?.MensagemErro != null && apiError.Errors.MensagemErro.Any()
                            ? string.Join(" | ", apiError.Errors.MensagemErro)
                            : apiError?.Detail ?? "Erro desconhecido.";

                        throw new HttpRequestException(
                            $"Erro {apiError?.Status} ({apiError?.Title}): {mensagens} [Instance: {apiError?.Instance}]");
                    }
                    catch (JsonException)
                    {
                        // Se não conseguir desserializar, inclui o conteúdo bruto
                        throw new HttpRequestException(
                            $"Erro desconhecido ao processar resposta da API. Conteúdo: {responseContent}");
                    }
                }
            }
            catch (HttpRequestException)
            {
                // Repassa HttpRequestException sem empacotar
                throw;
            }
            catch (Exception ex)
            {
                // Qualquer outra exceção vira ApplicationException
                throw new ApplicationException("Erro inesperado ao registrar entrada\n", ex);
            }
        }

        public async Task<Escala> RegistrarSaidaAsync(int idLinha, int idColaborador)
        {
            try
            {
                string rota = $"Escala/Saida/{idLinha}/{idColaborador}";
                HttpResponseMessage response = await _httpClient.PostAsync(rota, null);

                if (response.IsSuccessStatusCode)
                {
                    // Sucesso: desserializa o Escala
                    string json = await response.Content.ReadAsStringAsync();
                    var dto = JsonSerializer.Deserialize<Escala>(json, _jsonOptions);
                    return dto ?? new Escala();
                }
                else
                {
                    // Erro HTTP: lê o corpo
                    string responseContent = await response.Content.ReadAsStringAsync();

                    try
                    {
                        // Tenta desserializar o JSON de erro
                        var apiError = JsonSerializer.Deserialize<ApiErrorResponse>(
                            responseContent,
                            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                        var mensagens = apiError?.Errors?.MensagemErro != null && apiError.Errors.MensagemErro.Any()
                            ? string.Join(" | ", apiError.Errors.MensagemErro)
                            : apiError?.Detail ?? "Erro desconhecido.";

                        throw new HttpRequestException(
                            $"Erro {apiError?.Status} ({apiError?.Title}): {mensagens} [Instance: {apiError?.Instance}]");
                    }
                    catch (JsonException)
                    {
                        // Se falhar desserializar, joga o JSON bruto
                        throw new HttpRequestException(
                            $"Erro desconhecido ao processar resposta da API. Conteúdo: {responseContent}");
                    }
                }
            }
            catch (HttpRequestException)
            {
                // Repassa erros de API sem empacotar
                throw;
            }
            catch (Exception ex)
            {
                // Qualquer outro erro vira ApplicationException
                throw new ApplicationException("Erro inesperado ao registrar saída", ex);
            }
        }

        public async Task<List<ColaboradoresStatusResponse>> CarregarEscalaStatus(int idLinha)
        {
            try
            {
                string rota = $"Escala/Status/{idLinha}";
                HttpResponseMessage response = await _httpClient.GetAsync(rota);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var lista = JsonSerializer.Deserialize<List<ColaboradoresStatusResponse>>(json, options);
                    return lista ?? new List<ColaboradoresStatusResponse>();
                }
                else
                {
                    // Lê o conteúdo de erro
                    string responseContent = await response.Content.ReadAsStringAsync();

                    try
                    {
                        // Tenta desserializar o JSON de erro
                        var apiError = JsonSerializer.Deserialize<ApiErrorResponse>(
                            responseContent,
                            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                        var mensagens = apiError?.Errors?.MensagemErro != null && apiError.Errors.MensagemErro.Any()
                            ? string.Join(" | ", apiError.Errors.MensagemErro)
                            : apiError?.Detail ?? "Erro desconhecido.";

                        throw new HttpRequestException(
                            $"Erro {apiError?.Status} ({apiError?.Title}): {mensagens} [Instance: {apiError?.Instance}]");
                    }
                    catch (JsonException)
                    {
                        // Se falhar desserializar, joga o JSON bruto
                        throw new HttpRequestException(
                            $"Erro desconhecido ao processar resposta da API. Conteúdo: {responseContent}");
                    }
                }
            }
            catch (HttpRequestException)
            {
                // Repassa erros de requisição HTTP sem empacotar
                throw;
            }
            catch (Exception ex)
            {
                // Qualquer outro erro vira ApplicationException
                throw new ApplicationException("Erro inesperado ao carregar status da escala", ex);
            }
        }

        public async Task<string> ContarColaboradoresAtivosNaLinha(int idLinha, int origem)
        {
            try
            {
                var route = $"Escala/QuantidadeAtivos/{idLinha}/{origem}";
                Debug.WriteLine(_httpClient.BaseAddress + route);
                HttpResponseMessage response = await _httpClient.GetAsync(route);
                if (response.IsSuccessStatusCode)
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