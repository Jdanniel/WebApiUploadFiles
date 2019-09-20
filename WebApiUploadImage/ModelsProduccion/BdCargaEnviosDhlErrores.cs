using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class BdCargaEnviosDhlErrores
    {
        public int IdCargaEnvioDhlError { get; set; }
        public int? IdCargaEnvioDhl { get; set; }
        public string NoGuia { get; set; }
        public string Error { get; set; }
    }
}
