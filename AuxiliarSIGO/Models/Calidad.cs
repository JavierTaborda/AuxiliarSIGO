using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class Calidad
    {
        public int CalidadId { get; set; }
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public int? TipoProducId { get; set; }
        public int? EmpresaId { get; set; }
        public string? Wrk { get; set; }
        public string? Sord { get; set; }
    }
}
