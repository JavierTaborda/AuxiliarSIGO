using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class NivelAcceso
    {
        public int AccesoId { get; set; }
        public string? Descrpcion { get; set; }
        public bool? PerfilTrasversal { get; set; }
        public bool? Asentamiento { get; set; }
        public bool? Procesos { get; set; }
        public bool? ReportesVestimentas { get; set; }
        public bool? Auditoria { get; set; }
        public bool? Administrador { get; set; }
        public bool? AuditoriaBombas { get; set; }
        public bool? ReporteGerencial { get; set; }
        public bool? ReporteRegional { get; set; }
        public bool? PlanDeAccion { get; set; }
    }
}
