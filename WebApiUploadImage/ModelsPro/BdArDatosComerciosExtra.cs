﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class BdArDatosComerciosExtra
    {
        public int IdArDatoComercioExtra { get; set; }
        public int? IdAr { get; set; }
        public string NoAr { get; set; }
        public string Telefono { get; set; }
        public string PersonaAtendera { get; set; }
        public string ProveedorAtendera { get; set; }
    }
}
