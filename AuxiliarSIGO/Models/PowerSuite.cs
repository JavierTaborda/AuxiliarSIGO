using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class PowerSuite
    {
        public int PowersuiteId { get; set; }
        public int? DiscrepanciaId { get; set; }
        public int? MasterVariableId { get; set; }
        public string? NumeroPws { get; set; }
        public string? Observacion { get; set; }
        public int? FechaParada { get; set; }
        public int? HoraParada { get; set; }
        public int? FechaArranque { get; set; }
        public int? HoraArranque { get; set; }
        public int? FechaEstimada { get; set; }
        public int? Status { get; set; }
        public int? UsuarioId { get; set; }
    }
}
