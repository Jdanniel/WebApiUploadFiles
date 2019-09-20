using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class CDominiosEmail
    {
        public int IdDominioEmail { get; set; }
        public string DescDominioEmail { get; set; }
        public string Descripcion { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
