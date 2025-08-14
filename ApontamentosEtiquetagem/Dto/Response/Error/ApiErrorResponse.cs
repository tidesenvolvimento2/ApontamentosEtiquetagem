using ApontamentosEtiquetagem.Dto.Response.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApontamentoEtiquetagem.Dto.Response.Error
{
    public class ApiErrorResponse
    {
        public string Title { get; set; }
        public int Status { get; set; }
        public string Detail { get; set; }
        public string Instance { get; set; }
        public string TraceId { get; set; }
        public ApiErrorDetailsResponse Errors { get; set; }
    }
}
