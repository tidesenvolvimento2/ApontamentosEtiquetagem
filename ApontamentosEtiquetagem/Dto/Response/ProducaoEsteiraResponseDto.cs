using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApontamentosEtiquetagem.Dto.Response
{
    public class ProducaoEsteiraResponseDto
    {
        public int EsteiraId { get; set; }
        public int IdGalpao { get; set; }
        public string Nome { get; set; }
        public string NomeGalpao { get; set; }
    }
}
