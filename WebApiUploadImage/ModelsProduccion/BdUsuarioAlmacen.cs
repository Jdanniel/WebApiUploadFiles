using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class BdUsuarioAlmacen
    {
        public int IdUsuarioAlmacen { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdAlmacen { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
    }
}
