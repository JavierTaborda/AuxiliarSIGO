using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class VwReportDiario
    {
        public int Id { get; set; }
        public string? NombreVariable { get; set; }
        public string? CodEam { get; set; }
        public string? Expresion { get; set; }
        public string? Grupo { get; set; }
        public short? Turno { get; set; }
        public int? CentroTrabajoId { get; set; }
        public int? Fecha { get; set; }
        public int DataId { get; set; }
        public float? H0 { get; set; }
        public float? H2 { get; set; }
        public float? H4 { get; set; }
        public float? H6 { get; set; }
        public float? H8 { get; set; }
        public float? H10 { get; set; }
        public float? H12 { get; set; }
        public float? H14 { get; set; }
        public float? H16 { get; set; }
        public float? H18 { get; set; }
        public float? H20 { get; set; }
        public float? H22 { get; set; }
        public int? D1 { get; set; }
        public int? D2 { get; set; }
        public int? D3 { get; set; }
        public int? SeccionMaquinaId { get; set; }
        public string? Descripcion { get; set; }
        public float? Max { get; set; }
        public float? Min { get; set; }
        public int? TipoReporteId { get; set; }
    }
}
