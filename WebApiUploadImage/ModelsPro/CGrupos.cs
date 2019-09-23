﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class CGrupos
    {
        public CGrupos()
        {
            BdGruposClientes = new HashSet<BdGruposClientes>();
        }

        public int IdGrupo { get; set; }
        public string DescGrupo { get; set; }
        public string Descripcion { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdDocsTir { get; set; }

        public virtual ICollection<BdGruposClientes> BdGruposClientes { get; set; }
    }
}
