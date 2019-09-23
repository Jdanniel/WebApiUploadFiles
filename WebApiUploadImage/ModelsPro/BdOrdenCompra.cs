using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class BdOrdenCompra
    {
        public int IdOrdenCompra { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public int? IdStatusOrdenCompra { get; set; }
        public DateTime? FecOrdenCompra { get; set; }
    }
}
