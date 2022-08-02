using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class DataBomba
    {
        public int DataBombasId { get; set; }
        public int? MasterBombasId { get; set; }
        public string? Operativa { get; set; }
        public string? Fugas { get; set; }
        public int? Flujo { get; set; }
        public string? Trabaja { get; set; }
        public string? Alarma { get; set; }
        public string? Observaciones { get; set; }
        public int? Fecha { get; set; }
        public int? Hora { get; set; }
        public int? UsuarioId { get; set; }
        public int MaqParada { get; set; }
        public int? Incumplimiento { get; set; }
    }
}
