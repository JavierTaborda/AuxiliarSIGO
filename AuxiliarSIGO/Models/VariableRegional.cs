using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class VariableRegional
    {
        public int VariableRegionalId { get; set; }
        public int? VariableId { get; set; }
        public int? EmpresaId { get; set; }
        public string? LiteralVariable { get; set; }
    }
}
