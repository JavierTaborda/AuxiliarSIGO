using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class EquipoMuestreo
    {
        public int EquipoMuestreoId { get; set; }
        public int? EquipoId { get; set; }
        public int? PuntoMuestreoId { get; set; }
        public string? Codigo { get; set; }
    }
}
