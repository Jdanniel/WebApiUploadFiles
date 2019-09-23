using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class BdReglasAsignacionAutomatica
    {
        public int IdReglaAsignacionAutomatica { get; set; }
        public int? IdProducto { get; set; }
        public int? IdCliente { get; set; }
        public int? IdRegion { get; set; }
        public int? IdZona { get; set; }
        public int? IdTecnico { get; set; }
    }
}
