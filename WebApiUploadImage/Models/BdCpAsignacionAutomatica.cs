using System;
using System.Collections.Generic;

namespace WebApiUpload.Models
{
    public partial class BdCpAsignacionAutomatica
    {
        public int IdCpAsignacionAutomatica { get; set; }
        public int? IdReglaAsignacionAutomatica { get; set; }
        public string Cp { get; set; }
    }
}
