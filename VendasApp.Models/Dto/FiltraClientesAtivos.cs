using System;
using System.Collections.Generic;
using System.Text;
using VendasApp.Models.Enums;

namespace VendasApp.Models.Dto
{
    public class FiltraClientesAtivos
    {
        public bool Ativo { get; set; }
        public TipoDocumentoEnums.Tipodocumento Tipodocumento { get; set; }

        public string Cidade { get; set; }
    }
}
