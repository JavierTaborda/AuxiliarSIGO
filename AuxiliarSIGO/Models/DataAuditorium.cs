using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class DataAuditorium
    {
        public int DataAuditoriaId { get; set; }
        public int? MasterGeneralId { get; set; }
        public double? ValorIndicador { get; set; }
        public double? ValorCampo { get; set; }
        public int? Discrepancia { get; set; }
        public int? Fecha { get; set; }
        public int? Hora { get; set; }
        public int? UsuarioId { get; set; }
        public int? VariableId { get; set; }
        public int? CentroTrabajoId { get; set; }
        public int? UnidadMedidaId { get; set; }
        public int? MaqParada { get; set; }
        public int? Incumplimiento { get; set; }
    }
}
