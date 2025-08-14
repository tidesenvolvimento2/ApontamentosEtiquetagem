namespace ApontamentosEtiquetagem.Dto.Request;

public class ApontamentoDefeitoPostDto
{
    public string Codigo { get; set; }
    public string QrCode { get; set; }
    public string DataProducao { get; set; }
    public int Linha { get; set; }
    public string Op { get; set; }
    public int QtdOp { get; set; }
    public int QtdOperadores { get; set; }
    public int GalpaoId { get; set; }
    public int Apont_Ano { get; set; }
    public int Apont_Mes { get; set; }
    public int Apont_Dia { get; set; }
    public int Apont_Hora { get; set; }
    public int Apont_Min { get; set; }
    public int Sequencial { get; set; }
    public int IdMotivoDefeito { get; set; }
}