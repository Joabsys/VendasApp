using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VendasApp.Models
{
    public class VendasItem
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        [ForeignKey("Produto")]
        public int IdProduto { get; set; }
        public int IdVendas { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public virtual Vendas Vendas { get; set; }
    }
}
