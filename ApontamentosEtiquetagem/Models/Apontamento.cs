using System;

namespace ApontamentoEtiquetagemApp.Models
{
    public class Apontamento
    {
        public string OP { get; set; }
        public string QuantidadeOP { get; set; }
        public string CodigoPeca { get; set; }
        public string DescricaoPeca { get; set; }
        public string Data { get; set; }
        public string QuantidadePalete { get; set; }
        public string QuantidadeOperadores { get; set; }
        public string Situacao { get; set; }
    }
}
