using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class TipoReporte
    {
        public int TipoReporteId { get; set; }
        public string? Descripcion { get; set; }
        public int? AreaId { get; set; }
    }
}
