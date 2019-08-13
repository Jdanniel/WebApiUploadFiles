﻿using System;
using System.Collections.Generic;

namespace WebApiUpload.Models
{
    public partial class BdGarantiaAlmacen
    {
        public int IdGarantiaAlmacen { get; set; }
        public int? IdCliente { get; set; }
        public int? IdWeekDays { get; set; }
        public int? HorasGarantia { get; set; }
        public int? Horas { get; set; }
        public int? Minutos { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public string Status { get; set; }
    }
}
