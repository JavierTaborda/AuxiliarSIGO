using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class Prueba
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
        public int? Ht3 { get; set; }
        public float? Vt3 { get; set; }
        public double? Vct3 { get; set; }
        public int? Ht1 { get; set; }
        public float? Vt1 { get; set; }
        public double? Vct1 { get; set; }
        public int? Ht2 { get; set; }
        public float? Vt2 { get; set; }
        public double? Vct2 { get; set; }
        public int? D1 { get; set; }
        public int? D2 { get; set; }
        public int? D3 { get; set; }
        public int? SeccionMaquinaId { get; set; }
        public string? Descripcion { get; set; }
        public int? Orden { get; set; }
        public float? Max { get; set; }
        public float? Min { get; set; }
        public int? TipoReporteId { get; set; }
    }
}
