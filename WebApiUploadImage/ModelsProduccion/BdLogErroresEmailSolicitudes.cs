using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsProduccion
{
    public partial class BdLogErroresEmailSolicitudes
    {
        public int IdLogErrorEmail { get; set; }
        public string DescripcionError { get; set; }
        public string Modulo { get; set; }
        public DateTime? FechaAlta { get; set; }
    }
}
