using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class MasterGeneral
    {
        public int MasterGeneralId { get; set; }
        public string? VariableId { get; set; }
        public double? Desviacion { get; set; }
        public int? CentroTrabajoId { get; set; }
        public int? PuntoMuestreoId { get; set; }
        public int? EquipoId { get; set; }
        public int? UnidadMedidaId { get; set; }
        public double? LMin { get; set; }
        public double? LMax { get; set; }
        public int? FrecuenciaId { get; set; }
    }
}
