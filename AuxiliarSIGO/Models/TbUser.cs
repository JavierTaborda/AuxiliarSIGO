using System;
using System.Collections.Generic;

namespace AuxiliarSIGO.Models
{
    public partial class TbUser
    {
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Clave { get; set; }
        public bool Status { get; set; }
    }
}
