using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class TituloReporte
    {
        public int IdTitulo { get; set; }
        public string? NombreTitulo { get; set; }
        public int? Posicion { get; set; }
        public int? EmpresaId { get; set; }
        public int? AreaId { get; set; }
    }
}
