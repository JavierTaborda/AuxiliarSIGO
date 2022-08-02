using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class Literal
    {
        public int LiteralId { get; set; }
        public int? IdiomaId { get; set; }
        public string? CodLiteral { get; set; }
        public string? Literal1 { get; set; }
    }
}
