using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class DataReporte
    {
        public int DataReportesId { get; set; }
        public double? Valor { get; set; }
        public int? Discrepancia { get; set; }
        public string? UnidadMedidaId { get; set; }
        public int? MasterReporteId { get; set; }
        public int? Hora { get; set; }
        public int? Fecha { get; set; }
        public int? UsuarioId { get; set; }
        public int? Turno { get; set; }
        public string? Grupo { get; set; }
        public int? MaqParada { get; set; }
        public int? Incumplimiento { get; set; }
        public int? Procesada { get; set; }
        public double? Min { get; set; }
        public double? Max { get; set; }
        public int? TipoReporteId { get; set; }
        public int? EmpresaId { get; set; }
        public int? CentroTrabajoId { get; set; }
        public int? CalidadId { get; set; }
    }
}
