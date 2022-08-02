using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class Discrepancium
    {
        public int DiscrepanciaId { get; set; }
        public int? UsuarioId { get; set; }
        public int? DataId { get; set; }
        public double? ValorPlanAccion { get; set; }
        public int? Fecha { get; set; }
        public int? HoraValor { get; set; }
        public string? HoraAccion { get; set; }
        public string? Accion { get; set; }
        public int? Pws { get; set; }
        public int? StatusAccion { get; set; }
        public int? PwsStatus { get; set; }
        public int? Discrepancia2 { get; set; }
        public int? CategoriaId { get; set; }
    }
}
