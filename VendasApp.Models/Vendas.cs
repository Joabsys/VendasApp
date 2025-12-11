using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VendasApp.Models
{
    public class Vendas
    {
        public Vendas()
        {
            VendasItem = new List<VendasItem>();
        }
        public int Id { get; set; }
        [NotMapped]
        public string NomeDoCliente { get; set; }
        public Cliente Cliente { get; set; }
        [ForeignKey("Cliente")]
        public int ?IdCliente { get; set; }
        public decimal ValorTotal { get; set; }
        public virtual IList<VendasItem> VendasItem { get; set; }

    }
}
