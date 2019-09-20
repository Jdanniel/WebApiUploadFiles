using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class BdUsuarioStatusUnidad
    {
        public int IdUsuarioStatusUnidad { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdStatus { get; set; }
        public int? IsChecked { get; set; }
    }
}
