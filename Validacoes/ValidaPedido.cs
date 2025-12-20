using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasApp.Models;
using VendasApp.Repository;

namespace VendasApp.Validacoes
{
    public class ValidaPedido
    {
        private VendasRepository vendasRepository;
        private List<Vendas> IdVenda;

        public ValidaPedido()
        {
            vendasRepository = new VendasRepository(new Data.Contexto());
        }
        public bool validarPedido(int venda)
        {
            IdVenda = vendasRepository.BuscaID(venda);
            if (IdVenda.Count > 0)
                return true;
            else
            {
                return false;
            }
        }

    }
}
