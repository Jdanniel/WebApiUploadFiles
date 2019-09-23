﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class BdUsuarioArchivosVarios
    {
        public int IdUsuarioArchivosVarios { get; set; }
        public int? IdUsuario { get; set; }
        public string NombreArchivoSistema { get; set; }
        public string NombreArchivoUsuario { get; set; }
        public string Ruta { get; set; }
        public int? IdTipoArchivo { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaStatus { get; set; }
        public string Status { get; set; }
    }
}
