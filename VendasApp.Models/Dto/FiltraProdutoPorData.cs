using System;
using System.Collections.Generic;
using System.Text;

namespace VendasApp.Models.Dto
{
    public class FiltraProdutoPorData
    {
        public DateTime DataDeCadastro { get; set; }
        
        public bool Ativo { get; set; }
    }
}
