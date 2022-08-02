using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class ReporteArea
    {
        public int ReportAreaId { get; set; }
        public int? AreaId { get; set; }
        public int? TipoReporteId { get; set; }
    }
}
