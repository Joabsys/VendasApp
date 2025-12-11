using System;
using System.Collections.Generic;
using System.Text;

namespace VendasApp.Models.Dto
{
    public class FiltraProdutoPorDataValidade
    {
        public bool Ativo { get; set; }
        public DateTime DataDeValidade { get; set; }
    }
}
