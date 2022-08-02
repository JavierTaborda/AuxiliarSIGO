using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class Usuario
    {
        public int UsuarioId { get; set; }
        public string? Nombre { get; set; }
        public string? Login { get; set; }
        public string? Clave { get; set; }
        public int? NivelaccesoId { get; set; }
        public int? EmpresaId { get; set; }
        public bool? StatusClave { get; set; }
        public int? Status { get; set; }
        public int? CargoId { get; set; }
        public int? AreaId { get; set; }
        public int? EquipoId { get; set; }
    }
}
