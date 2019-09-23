using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class BdUploadEstafeta
    {
        public int IdUploadEstafeta { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
