using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class BdUsuarioTecnico
    {
        public int IdUsuarioTecnico { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdTecnico { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
    }
}
