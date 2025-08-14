namespace ApontamentosEtiquetagem.Dto.Response
{
    public  class ApontamentoDto
    {
        public string QrCode { get; set; }
        public string Codigo { get; set; }
        public string DataProducao {  get; set; }
        public string Linha { get; set; }
        public string Op {  get; set; }
        public int QtdOperadores { get; set; }
    }
}
