using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class CentroTrabajo
    {
        public int CentroTrabajoId { get; set; }
        public int? EmpresaId { get; set; }
        public int? CodCentroTrabajo { get; set; }
        public string? NombreCentroTrabajo { get; set; }
        public int? AreaId { get; set; }
        public int? Status { get; set; }
        public int? DivisionId { get; set; }
    }
}
