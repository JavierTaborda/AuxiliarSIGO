using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class TbInvPartesAr
    {
        public int IdReg { get; set; }
        public int IdPais { get; set; }
        public string? Ptloc { get; set; }
        public string? Ptpart { get; set; }
        public string? Ptcntl { get; set; }
        public string? Ptdesc { get; set; }
        public string? Ptbin1 { get; set; }
        public string? Ptbin2 { get; set; }
        public long? Pttext { get; set; }
        public long? Teseq { get; set; }
        public string? Tetext { get; set; }
        public int? Ptcmpy { get; set; }
    }
}
