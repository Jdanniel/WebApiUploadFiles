﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class CProyectosPmo
    {
        public int IdProyectoPmo { get; set; }
        public int? IdCliente { get; set; }
        public int? IdUsuario { get; set; }
        public string Perfil { get; set; }
        public string Status { get; set; }
    }
}
