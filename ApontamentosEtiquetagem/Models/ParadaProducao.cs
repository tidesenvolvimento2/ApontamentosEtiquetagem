using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApontamentosProducao.Models
{
    public class ParadaProducao
    {
        [Key]
        public int IdParada { get; set; }
        public int IdMotParada { get; set; }
        public string Motivo { get; set; }
        public string OP { get; set; }
        public string Codigo_Prod { get; set; }
        public DateTime DtInicioParada { get; set; }
        public string UserAbertura { get; set; }
        public DateTime DtFinalParada { get; set; }
        public string UserFechamento { get; set; }
        public string Observacao { get; set; }

    }
}
