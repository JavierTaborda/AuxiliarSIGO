using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class Variable
    {
   
        public int IdVariable { get; set; }
        public string? NombreVariable { get; set; }
        public int? TituloReporteId { get; set; }
        public int? TipoVariableId { get; set; }
        public string? CodRegional { get; set; }
        public int? TipoReporteId { get; set; }
        public int? AreaId { get; set; }
        public int? Agrupado { get; set; }



    }
}
