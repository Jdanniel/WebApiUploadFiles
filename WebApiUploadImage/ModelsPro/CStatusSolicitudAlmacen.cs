﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class CStatusSolicitudAlmacen
    {
        public CStatusSolicitudAlmacen()
        {
            BdBitacoraSolicitudesAlmacenIdStatusSolicitudAlmacenFinNavigation = new HashSet<BdBitacoraSolicitudesAlmacen>();
            BdBitacoraSolicitudesAlmacenIdStatusSolicitudAlmacenIniNavigation = new HashSet<BdBitacoraSolicitudesAlmacen>();
        }

        public int IdStatusSolicitudAlmacen { get; set; }
        public string DescStatusSolicitudAlmacen { get; set; }
        public int? IsConfirmarEntrega { get; set; }
        public int? IsHabilitaConfirmar { get; set; }
        public int? IsCancelado { get; set; }
        public int? IsFlujoAlmacen { get; set; }
        public string Status { get; set; }

        public virtual ICollection<BdBitacoraSolicitudesAlmacen> BdBitacoraSolicitudesAlmacenIdStatusSolicitudAlmacenFinNavigation { get; set; }
        public virtual ICollection<BdBitacoraSolicitudesAlmacen> BdBitacoraSolicitudesAlmacenIdStatusSolicitudAlmacenIniNavigation { get; set; }
    }
}
