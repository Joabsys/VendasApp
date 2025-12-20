using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasApp.Models;
using VendasApp.Repository;

namespace VendasApp.Validacoes
{
    public class ValidaProduto
    {
        private ProdutoRepository produtoRepository;
        private List<Produto> validarproduto;
        public ValidaProduto()
        {

            produtoRepository = new ProdutoRepository(new Data.Contexto());
        }
        public bool ValidarProduto(int produto)
        {
            validarproduto = produtoRepository.BuscarId(produto);
            if (validarproduto.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
