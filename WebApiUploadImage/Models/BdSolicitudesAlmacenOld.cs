﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models;

public partial class BdSolicitudesAlmacenOld
{
    public int IdSolicitudAlmacen { get; set; }

    public int IdAlmacen { get; set; }

    public int IdTipoSolicitudAlmacen { get; set; }

    public int IdUrgenciaSolicitudAlmacen { get; set; }

    public int IdAr { get; set; }

    public int IdStatusSolicitudAlmacen { get; set; }

    public int? IdMarca { get; set; }

    public int? IdModelo { get; set; }

    public int? IdInsumo { get; set; }

    public int? IdSparePart { get; set; }

    public int? CantidadSparePart { get; set; }

    public string Notas { get; set; }

    public int IdTipoResponsableDestino { get; set; }

    public int IdResponsableDestino { get; set; }

    public int IdUsuarioAlta { get; set; }

    public DateTime FecAlta { get; set; }

    public int? IdUsuarioConfirm { get; set; }

    public DateTime? FecConfirm { get; set; }

    public virtual CAlmacene IdAlmacenNavigation { get; set; }

    public virtual CUsuario IdResponsableDestinoNavigation { get; set; }

    public virtual CSparePart IdSparePartNavigation { get; set; }

    public virtual CTipoResponsable IdTipoResponsableDestinoNavigation { get; set; }

    public virtual CTipoSolicitudAlmacen IdTipoSolicitudAlmacenNavigation { get; set; }

    public virtual CUrgenciaSolicitudAlmacen IdUrgenciaSolicitudAlmacenNavigation { get; set; }

    public virtual CUsuario IdUsuarioAltaNavigation { get; set; }

    public virtual CUsuario IdUsuarioConfirmNavigation { get; set; }
}
