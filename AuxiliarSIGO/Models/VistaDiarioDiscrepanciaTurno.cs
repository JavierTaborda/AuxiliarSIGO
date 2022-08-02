using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class VistaDiarioDiscrepanciaTurno
    {
        public int? Id { get; set; }
        public string? Descripcion { get; set; }
        public string? NombreVariable { get; set; }
        public string? Expresion { get; set; }
        public int? CentroTrabajoId { get; set; }
        public int? Fecha { get; set; }
        public float? Turno1 { get; set; }
        public float? Turno2 { get; set; }
        public float? Turno3 { get; set; }
        public int? D1 { get; set; }
        public int? D2 { get; set; }
        public int? D3 { get; set; }
        public float? H22 { get; set; }
        public float? H00 { get; set; }
        public float? H02 { get; set; }
        public float? H04 { get; set; }
        public float? H06 { get; set; }
        public float? H08 { get; set; }
        public float? H10 { get; set; }
        public float? H12 { get; set; }
        public float? H14 { get; set; }
        public float? H16 { get; set; }
        public float? H18 { get; set; }
        public float? H20 { get; set; }
        public string? CodEam { get; set; }
        public int? Hora { get; set; }
    }
}
