using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class Equipo
    {
        public int EquipoId { get; set; }
        public string? CodEam { get; set; }
        public string? Descripcion { get; set; }
        public bool? Status { get; set; }
        public string? CentroCosto { get; set; }
        public int? EmpresaId { get; set; }
        public int? CentroTrabajoId { get; set; }
    }
}
