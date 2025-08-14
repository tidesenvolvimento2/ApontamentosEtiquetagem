using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Producao.Model;

[Table("producao_escala")]
public class Escala
{
    [Key]
    public int IdEscala { get; set; }

    public int IdLinha { get; set; }

    [Column("idColab")]
    public int IdColaborador { get; set; }

    public DateTime DataRegistro { get; set; }

    public DateTime DataInicio { get; set; }

    public DateTime DataFim { get; set; }
    public int Origem { get; set; }
}