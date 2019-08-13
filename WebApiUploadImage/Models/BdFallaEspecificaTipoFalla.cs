using System;
using System.Collections.Generic;

namespace WebApiUpload.Models
{
    public partial class BdFallaEspecificaTipoFalla
    {
        public int IdFallaEspecificaTipoFalla { get; set; }
        public int? IdFalla { get; set; }
        public int? IdTipoFalla { get; set; }
        public int? IdEspecifTipoFalla { get; set; }
        public int? IdCliente { get; set; }
        public string Status { get; set; }
    }
}
