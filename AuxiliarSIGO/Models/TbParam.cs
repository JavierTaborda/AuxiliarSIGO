using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class TbParam
    {
        public bool? ParModoPeso { get; set; }
        public string? ParComm1 { get; set; }
        public string? ParComm2 { get; set; }
        public string? ParComm3 { get; set; }
        public string? ParComm4 { get; set; }
        public byte? ParComZebra { get; set; }
        public byte? ParComPeso { get; set; }
        public int? ParUpdate { get; set; }
        public int? IdPais { get; set; }
        public string? Estacion { get; set; }
        public bool? StsEqu { get; set; }
        public bool? StsEst { get; set; }
        public string? SLoc { get; set; }
        public string? ISerie { get; set; }
        public string? LibL { get; set; }
    }
}
