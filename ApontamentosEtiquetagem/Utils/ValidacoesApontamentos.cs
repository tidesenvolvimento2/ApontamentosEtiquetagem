using System.Text.RegularExpressions;
using ApontamentosEtiquetagem.Dto.Response;

namespace ApontamentosEtiquetagem.Utils;

public static class ValidacoesApontamentos
{
    public static async Task<bool> ValidarQrcode(string qrcode)
    {
        string padrao = @"^[A-Z0-9]{26}$";

        return Regex.IsMatch(qrcode, padrao);
    }

    public static async Task<bool> ValidarOp(OrdemProducaoDto op, string qrcode)
    {
        string codigo = qrcode.Substring(10, 9);
        return string.Equals(codigo, op.CodigoProduto);
    }

    public static async Task<bool> ValidarGalpao(string qrcode, GalpaoResponseDto galpao)
    {
        if(qrcode[ 19 ] != galpao.Letra[ 0 ])
            return false;

        return true;
    }
}