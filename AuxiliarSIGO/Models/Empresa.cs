using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class Empresa
    {
        public int IdEmpresa { get; set; }
        public string Empresa1 { get; set; } = null!;
        public int? Codigo { get; set; }
        public int? Idioma { get; set; }
    }
}
