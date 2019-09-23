﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.ModelsPro
{
    public partial class BdConfirmacionesIntermedia
    {
        public int IdConfirmacionIntermedia { get; set; }
        public int? IdCargaConfirmaciones { get; set; }
        public int? IdSolicitudViaticos { get; set; }
        public string NumConfirmacion { get; set; }
        public string Status { get; set; }

        public virtual BdCargasConfirmaciones IdCargaConfirmacionesNavigation { get; set; }
        public virtual BdSolicitudesViaticos IdSolicitudViaticosNavigation { get; set; }
    }
}
