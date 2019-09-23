﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class BdAuditoriaCierres
    {
        public int IdAuditoriaCierres { get; set; }
        public int? IdTabla { get; set; }
        public string Proceso { get; set; }
        public string TablaAfectada { get; set; }
        public string Accion { get; set; }
        public string Descripcion { get; set; }
        public int? IdArchivo { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? Paso { get; set; }
    }
}
