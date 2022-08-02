using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class TbInvPartesTmp
    {
        public int IdReg { get; set; }
        public int IdPais { get; set; }
        public string Ptloc { get; set; } = null!;
        public string Ptpart { get; set; } = null!;
        public string Ptcntl { get; set; } = null!;
        public string Ptdesc { get; set; } = null!;
        public string Ptbin1 { get; set; } = null!;
        public string Ptbin2 { get; set; } = null!;
        public decimal Pttext { get; set; }
        public decimal Teseq { get; set; }
        public string Tetext { get; set; } = null!;
        public int? Ptcmpy { get; set; }
    }
}
