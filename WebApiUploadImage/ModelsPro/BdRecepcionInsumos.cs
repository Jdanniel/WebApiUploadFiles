using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class BdRecepcionInsumos
    {
        public int IdRecepcionInsumo { get; set; }
        public int? IdOrdenCompra { get; set; }
        public int? IdInsumo { get; set; }
        public double? CantidadRecepcionada { get; set; }
    }
}
