using System;
using System.Collections.Generic;
using System.Text;
using VendasApp.Models.Enums;

namespace VendasApp.Models.Dto
{
    public class FiltraClientesAtivosPorCidade
    {
        public string Cidade { get; set; }
        public bool Ativo { get; set; }
        public TipoDocumentoEnums.Tipodocumento Tipodocumento { get; set; } 
    }
}
