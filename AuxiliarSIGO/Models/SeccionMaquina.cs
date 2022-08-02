using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class SeccionMaquina
    {
        public int SeccionMaquinaId { get; set; }
        public string? Descripcion { get; set; }
        public int? AreaId { get; set; }
        public int? Orden { get; set; }
    }
}
