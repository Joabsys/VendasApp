using System;
using System.Collections.Generic;
using System.Text;
using VendasApp.Models.Enums;

namespace VendasApp.Models
{
    public class Fornecedor
    {
        public int? Id { get; set; }
        public bool? Ativo { get; set; }
        public string Nome { get; set; }
        public string Cep { get; set; }
        public TipoDocumentoEnums.Tipodocumento? Tipodocumento { get; set; }
        public string Documento { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
    }
}
