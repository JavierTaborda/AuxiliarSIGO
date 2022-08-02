using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class ConvertirUnidad
    {
        public int ConversionUnidadId { get; set; }
        public int? UnidadaBase { get; set; }
        public int? UnidadDestino { get; set; }
        public double? Factor { get; set; }
    }
}
