using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class MasterVariable
    {
      
        public int Id { get; set; }
        public int? EquipoId { get; set; }
        public int? VariableId { get; set; }
        public string? CalidadId { get; set; }
        public int? PuntoMuestreoId { get; set; }
        public int? TipoVariableId { get; set; }
        public int? EncabezadoId { get; set; }
        public int? SeccionMaquinaId { get; set; }
        public int? FrecuenciaId { get; set; }
        public int? TituloReporteId { get; set; }
        public int? CentroTrabajoId { get; set; }
        public double? Max { get; set; }
        public double? Min { get; set; }
        public double? Limin { get; set; }
        public double? Limax { get; set; }
        public int? PosReporte { get; set; }
        public int? PosFormato { get; set; }
        public bool? Status { get; set; }
        public int? UnidadMedidaId { get; set; }
        public bool? Discrepancia { get; set; }
        public bool? Auditoria { get; set; }
        public int? StatusPws { get; set; }
        public int? Bolean { get; set; }
        public int? TipoReporteId { get; set; }





    }
}
