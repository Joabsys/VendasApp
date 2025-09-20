using System;
using System.Collections.Generic;
using System.Text;

namespace VendasApp.Models
{
    public class Produto
    {
      public int? Id { get; set; }
        public decimal? Preco { get; set; }
        public string Descricao { get; set; }
        public bool? Ativo { get; set; }
        public int? Quantidade { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataValidade { get; set; }

    }
}
