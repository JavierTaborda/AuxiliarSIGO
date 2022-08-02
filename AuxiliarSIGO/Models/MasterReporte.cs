using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class MasterReporte
    {
        public int MasterReportesId { get; set; }
        public int? VariableId { get; set; }
        public double? Max { get; set; }
        public double? Min { get; set; }
        public int? CentroTrabajoId { get; set; }
        public int? EmpresaId { get; set; }
        public int? UnidadMedidaId { get; set; }
        public int? PuntoMuestreoId { get; set; }
        public double? LimMax { get; set; }
        public double? LimMin { get; set; }
        public int? FrecuenciaId { get; set; }
        public int? MasterVariableId { get; set; }
    }
}
