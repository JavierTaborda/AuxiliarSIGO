using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class PuntoMuestreo
    {
        public int PuntoMuestreoId { get; set; }
        public string? Descripcion { get; set; }
        public int? EmpresaId { get; set; }
        public int? EquipoId { get; set; }
        public int? PosicionFormulario { get; set; }
        public string? Codigo { get; set; }
        public int? AreaId { get; set; }
    }
}
