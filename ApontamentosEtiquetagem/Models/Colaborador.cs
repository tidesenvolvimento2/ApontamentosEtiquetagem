using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApontamentosEtiquetagem.Models
{
    [Table("producao_colaborador")]
    public class Colaborador
    {
        [Key]
        [Column("idColab")]
        public int IdColaborador { get; set; }

        public string Nome { get; set; }

        public string Funcao { get; set; }
        public int Ativo { get; set; } // 0 - Inativo, 1 - Ativo

        public DateTime DataRegistro { get; set; }

        public int IdUserRegistro { get; set; }
    }
}