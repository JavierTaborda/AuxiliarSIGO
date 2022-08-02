using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class Datum
    {
        public int DataId { get; set; }
        public int? SeccionMaquinaId { get; set; }
        public float? Valor { get; set; }
        public int? Hora { get; set; }
        public int? Fecha { get; set; }
        public int? TipoReporteId { get; set; }
        public short? Turno { get; set; }
        public string? Grupo { get; set; }
        public int? UnidadMedidaId { get; set; }
        public int? MasterVariableId { get; set; }
        public int? UsuarioId { get; set; }
        public int? EmpresaId { get; set; }
        public string? CalidadId { get; set; }
        public int? Procesada { get; set; }
        public int? Discrepancia { get; set; }
        public float? Max { get; set; }
        public float? Min { get; set; }
        public int? MaqParada { get; set; }
        public int? Incumplimiento { get; set; }
        public int? Bolean { get; set; }
        public int? CentroTrabajoId { get; set; }
        public int? Formulario { get; set; }
    }
}
