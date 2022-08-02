using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class Categorium
    {
        public int CategoriaId { get; set; }
        public string? Descripcion { get; set; }
        public string? DescripcionAlterna { get; set; }
        public int? Posicion { get; set; }
    }
}
