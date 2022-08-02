using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class VarDif
    {
        public int DifVarCalId { get; set; }
        public int VarResultId { get; set; }
        public int? VarOper1Id { get; set; }
        public int? VarOper2Id { get; set; }
        public int? PaisId { get; set; }
    }
}
