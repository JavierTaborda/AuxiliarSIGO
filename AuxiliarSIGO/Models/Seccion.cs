using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class Seccion
    {
        public int IdSeccion { get; set; }
        public int EquipoId { get; set; }
        public string CodSeccion { get; set; } = null!;
        public string? NombreSeccion { get; set; }
    }
}
