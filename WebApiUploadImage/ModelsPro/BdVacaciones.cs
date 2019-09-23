﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class BdVacaciones
    {
        public int IdVacaciones { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FecSolicitud { get; set; }
        public DateTime? FecInicio { get; set; }
        public DateTime? FecTermina { get; set; }
        public int? Periodo { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
    }
}
