using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class Rotacion
    {
        public int RotacionId { get; set; }
        public int? EmpresaId { get; set; }
        public string? T1 { get; set; }
        public string? T2 { get; set; }
        public string? T3 { get; set; }
        public int? Anio { get; set; }
        public int? Mes { get; set; }
        public int? Fecha { get; set; }
        public string? Libre { get; set; }
    }
}
