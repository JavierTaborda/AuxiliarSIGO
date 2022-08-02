using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class MasterBomba
    {
        public int MasterBombasId { get; set; }
        public int? EquipoId { get; set; }
        public int? FlujoGpm { get; set; }
        public int? CentroTrabajoId { get; set; }
        public int? TipoReporteId { get; set; }
    }
}
