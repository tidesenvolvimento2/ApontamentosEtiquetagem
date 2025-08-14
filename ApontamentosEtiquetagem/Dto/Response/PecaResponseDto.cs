using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApontamentoEtiquetagem.Dto.Response
{
    public class PecaResponseDto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string LinkImagem { get; set; }
    }
}
